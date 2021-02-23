using ClinicApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.View
{ 
    public partial class NewRecordForm : Form
    {
        ClinicDBEntities contex;
        int cardID;
        int recordNumber;
        public NewRecordForm(Card card)
        {
            InitializeComponent();
            contex = new ClinicDBEntities();
            cardNumberLbl.Text = card.CardNumber.ToString();
            cardID = card.Id;
            recordNumber = lastCardRecord() + 1;
            cardRecordLbl.Text = recordNumber.ToString();
            dataLbl.Text = DateTime.Now.Date.ToString("dd.MM.yyyy");
        }

        private int lastCardRecord()
        {
            int lastNumber;
            if (contex.GetCardRecordsByCardId(cardID).ToList().Count != 0)
            {
                CardRecordsWithDoctorNameView record = contex.GetCardRecordsByCardId(cardID).ToList().LastOrDefault<CardRecordsWithDoctorNameView>();
                lastNumber = record.RecordNumber;
            }
            else
                lastNumber = 0;
            return lastNumber;
        }

        private void NewRecordForm_Load(object sender, EventArgs e)
        {
            contex.Configuration.ProxyCreationEnabled = false;
            contex.Configuration.LazyLoadingEnabled = false;
            var doctors = contex.ClinicEmployee.ToList();
            foreach (ClinicEmployee ce in doctors)
                doctorComboBox.Items.Add(ce.FIO);
            doctorComboBox.SelectedIndex = 0;
            var medicines = contex.Medicine.ToList();
            foreach (Medicine m in medicines)
                medicineComboBox.Items.Add(m.MedicineName);
            medicineComboBox.SelectedIndex = 0;

            var tests = contex.MedicalTest.ToList();
            foreach (MedicalTest t in tests)
                testsComboBox.Items.Add(t.TestName);
            testsComboBox.SelectedIndex = 0;      
        }

        private async void saveRecordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //await contex.SaveChangesAsync();
                
                CardRecord cardRecord = new CardRecord();
                cardRecord.CardID = cardID;
                cardRecord.RecordNumber = recordNumber;
                cardRecord.Diaghosis = diaghosisTextBox.Text;
                string docterFIO = doctorComboBox.SelectedItem.ToString();
                cardRecord.AddInfo = addInfoTextBox.Text;
                cardRecord.RecordDate = DateTime.Now.Date;
                cardRecord.ClinicEmployeeID = (int)contex.GetDocterID(docterFIO).ToList().FirstOrDefault();
                //contex.InsertCardRecord(recordNumber, cardRecord.Diaghosis, cardRecord.AddInfo, DateTime.Now.Date, cardRecord.ClinicEmployeeID, cardID);
                contex.CardRecord.Add(cardRecord);
                foreach (DataGridViewRow row in medicineGridView.Rows)
                {
                    CardRecordMedicine cardRecordMedicine = new CardRecordMedicine();
                    string medicineName = row.Cells[0].Value.ToString();
                    var medicines = contex.GetMedicineByName(medicineName).ToList();
                    foreach (Medicine m in medicines)
                    {
                        cardRecordMedicine.MedicineID = m.Id;
                        cardRecordMedicine.CardRecordID = cardRecord.Id;
                        cardRecord.CardRecordMedicine.Add(cardRecordMedicine);
                        contex.CardRecordMedicine.Add(cardRecordMedicine);
                    }   
                   
                }
                foreach (DataGridViewRow row in testsGridView.Rows)
                {
                    CardRecordMedicalTest cardRecordMedicalTest = new CardRecordMedicalTest();
                    string testName = row.Cells[0].Value.ToString();
                    var tests = contex.GetTestByName(testName);
                    foreach (MedicalTest m in tests)
                    {
                        cardRecordMedicalTest.MedicalTestID = m.Id;
                        cardRecordMedicalTest.CardRecordID = cardRecord.Id;
                        cardRecord.CardRecordMedicalTest.Add(cardRecordMedicalTest);
                        contex.CardRecordMedicalTest.Add(cardRecordMedicalTest);
                    }
                }
                contex.SaveChanges();             
                MessageBox.Show("Успешно сохранино", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addMedicineBtn_Click(object sender, EventArgs e)
        {
            string medicineName = medicineComboBox.SelectedItem.ToString();      
            var medicines = contex.GetMedicineByName(medicineName);
            medicineGridView.Rows.Add();
            deleteColumn.DefaultCellStyle.NullValue = "Удалить";
            int rowIndex = this.medicineGridView.Rows.Count - 1;
            foreach (Medicine m in medicines)
            {
                this.medicineGridView.Rows[rowIndex].Cells[0].Value = m.MedicineName;
                this.medicineGridView.Rows[rowIndex].Cells[1].Value = m.OneTimeQuantity;
                this.medicineGridView.Rows[rowIndex].Cells[2].Value = m.DayTimes;
                this.medicineGridView.Rows[rowIndex].Cells[3].Value = m.Duration;
            }         
        }

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            string testName = testsComboBox.SelectedItem.ToString();
            var tests = contex.GetTestByName(testName);
            testsGridView.Rows.Add();
            deleteBtnColumn.DefaultCellStyle.NullValue = "Удалить";
            int rowIndex = this.testsGridView.Rows.Count - 1;
            foreach (MedicalTest m in tests)
            {
                this.testsGridView.Rows[rowIndex].Cells[0].Value = m.TestName;
                this.testsGridView.Rows[rowIndex].Cells[1].Value = m.Price.ToString();
                this.testsGridView.Rows[rowIndex].Cells[2].Value = m.Info;
            }
        }
    }
}
