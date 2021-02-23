using ClinicApp.Model;
using ClinicApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp
{
    public partial class Form1 : Form
    {
        ClinicDBEntities contex;
        static DataTable dt;
       
        public Form1()
        {
            InitializeComponent();
            OpenButton = new DataGridViewButtonColumn();
            DeleteButton = new DataGridViewButtonColumn();
            dt = new DataTable();
            
        }

        Image CloseImage;
        private void Form1_Load(object sender, EventArgs e)
        {
            /*дДобавление картинки для закрытия tabPage*/
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += TabControl2_DrawItem;
            tabControl1.MouseClick += tabControl2_MouseClick;
            CloseImage = Properties.Resources.Close;
            tabControl1.Padding = new Point(12, 3);

            contex = new ClinicDBEntities();     
         
            dt.Columns.Add("ID");
            dt.Columns.Add("ФИО");
            dt.Columns.Add("Телефон");
            dt.Columns.Add("Номер карты");

            refreshGrid();

            patientsGridView.Columns.Add(OpenButton);
            patientsGridView.Columns.Add(DeleteButton);
            
            // 
            // Open Patient Button
            // 
            OpenButton.HeaderText = "Открыть карту";
            OpenButton.DefaultCellStyle.NullValue = "Открыть";
            OpenButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            // 
            // Delete Patient Button
            //               
            DeleteButton.HeaderText = "Удалить карту";
            DeleteButton.DefaultCellStyle.NullValue = "Удалить";
            DeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataColumn dcRowString = dt.Columns.Add("_RowString", typeof(string));
            addColumnForFiltering(dcRowString);

            patientsGridView.AllowUserToAddRows = false;
        }
        /*прорисовка и добовление событий для рисунка "Закрить" на каждой tapPage кроме первой*/
        /*Первая страница(страницы со списком) не закриваеться*/
        #region
        private void TabControl2_DrawItem(object sender,
                                          System.Windows.Forms.DrawItemEventArgs e)
        {
            try
            {
                var tabRect = tabControl1.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);

                var sf = new StringFormat(StringFormat.GenericDefault);
                if (tabControl1.RightToLeft == System.Windows.Forms.RightToLeft.Yes &&
                    tabControl1.RightToLeftLayout == true)
                {
                    tabRect = GetRTLCoordinates(tabControl1.ClientRectangle, tabRect);
                    imageRect = GetRTLCoordinates(tabControl1.ClientRectangle, imageRect);
                    sf.FormatFlags |= StringFormatFlags.DirectionRightToLeft;
                }

                e.Graphics.DrawString(tabControl1.TabPages[e.Index].Text,
                                      this.Font, Brushes.Black, tabRect, sf);
                e.Graphics.DrawImage(CloseImage, imageRect.Location);

            }
            catch (Exception) { }
        }
        private void tabControl2_MouseClick(object sender, MouseEventArgs e)
        {
            for (var i = 1; i < tabControl1.TabPages.Count; i++)
            {
                var tabRect = tabControl1.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var imageRect = new Rectangle(tabRect.Right - CloseImage.Width,
                                         tabRect.Top + (tabRect.Height - CloseImage.Height) / 2,
                                         CloseImage.Width,
                                         CloseImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    tabControl1.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
        public static Rectangle GetRTLCoordinates(Rectangle container, Rectangle drawRectangle)
        {
            return new Rectangle(
                container.Width - drawRectangle.Width - drawRectangle.X,
                drawRectangle.Y,
                drawRectangle.Width,
                drawRectangle.Height);
        }
        #endregion
        public static void addColumnForFiltering(DataColumn dcRowString)
        {
            //add not visible column for filtering       
            foreach (DataRow dataRow in dt.Rows)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    sb.Append(dataRow[i].ToString());
                    sb.Append("\t");
                }
                dataRow[dcRowString] = sb.ToString();
            }
           patientsGridView.Columns["_RowString"].Visible = false;
        }

        private int lastCardNumber()
        {
            int lastNumber = 0;
            Card card = contex.Card.ToList().LastOrDefault<Card>();
            lastNumber = card.CardNumber;
            return lastNumber;
        }


        private void newPatientBtn_Click(object sender, EventArgs e)
        {
            Card newCard = new Card();
            newCard.CardNumber = lastCardNumber()+1;
            contex.Card.Add(newCard);        
            AddNewPatientForm addNewPatientForm = new AddNewPatientForm(newCard);
            addNewPatientForm.Visible = true;
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("[_RowString] LIKE '%{0}%'", searchTextBox.Text);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = searchTextBox.Text;
            var patients = contex.PatientsByFIO(text);         
            patientsGridView.DataSource = patients;
        }

        private void patientsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            int patientID = int.Parse(patientsGridView.Rows[e.RowIndex].Cells[2].Value.ToString());

            //нажатие на кнопку открыть карту
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                try
                {
                    var patients = contex.GetPatientByID(patientID);
                    
                    foreach (Patient p in patients)
                    {
                        PatientPage patientPage = new PatientPage(p);
                        patientPage.Name = p.Id.ToString();
                        patientPage.Text = p.FIO;
                        
                        tabControl1.TabPages.Add(patientPage);
                        tabControl1.SelectedTab = patientPage;

                    }
                    
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                //нажатие на кнопку удалить пациента
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && e.ColumnIndex == 1)
                {
                    if (MessageBox.Show("Вы дествительно хотите удалить пациента и его карту?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var patients = contex.GetPatientByID(patientID).ToList();

                        foreach (Patient p in patients)
                        {
                            Card pCard = p.Card;
                            foreach (CardRecord cardRecord in pCard.CardRecord.ToList())
                            {
                                foreach (CardRecordMedicine cardRecordMedicine in cardRecord.CardRecordMedicine.ToList())
                                    contex.CardRecordMedicine.Remove(cardRecordMedicine);
                                foreach (CardRecordMedicalTest cardRecordMedicalTest in cardRecord.CardRecordMedicalTest.ToList())
                                    contex.CardRecordMedicalTest.Remove(cardRecordMedicalTest);
                                contex.CardRecord.Remove(cardRecord);
                            }
                            contex.Card.Remove(p.Card);
                            contex.Patient.Remove(p);
                        }
                        contex.SaveChanges();
                        refreshGrid();
                    }
                   
                }
            }
        }

        private void refreshGrid()
        {
            if (dt.Rows.Count != 0) dt.Rows.Clear();
            foreach (var row in contex.Patient.ToList())
                dt.Rows.Add(row.Id, row.FIO, row.Phone, row.Card.CardNumber);

            patientsGridView.DataSource = dt;
        }
 
        private void exidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutProgramBox aboutProgramBox = new AboutProgramBox();
            aboutProgramBox.Visible = true;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void patientsByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void patientsByDiaghosisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientsByDoctorNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
