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
    public partial class PatientPage : TabPage
    {
       

        private GroupBox groupBox1;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox cardNumTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private TextBox birthDateTextBox;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox fioTextBox;
        private GroupBox groupBox2;
        private DataGridView cardRecordsGridView;
        private TableLayoutPanel tableLayoutPanel3;
        private Button searchByDiaghosisBtn;
        private TextBox diaghosisTextBox;
        private Button newRecBtn;
        private TableLayoutPanel tableLayoutPanel4;
        private Button searchByDate;
        private DateTimePicker dateTextBox;
        private TableLayoutPanel topLayout;
        private DataGridViewColumn recordNumberColumn;
        private DataGridViewColumn recordDateColumn;
        private DataGridViewColumn diaghosisColumn;
        private DataGridViewColumn docterFioColumn;
        private DataGridViewButtonColumn OpenButton;
        private Button refreshButton;
        private ClinicDBEntities contex;
        private int cardID;
        private Patient thisPatient;
        public PatientPage(Patient patient)
        {
            recordNumberColumn = new DataGridViewColumn();
            recordDateColumn = new DataGridViewColumn();
            diaghosisColumn = new DataGridViewColumn();
            docterFioColumn = new DataGridViewColumn();
            OpenButton = new DataGridViewButtonColumn();

            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            fioTextBox = new TextBox();
            birthDateTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            cardNumTextBox = new TextBox();
            diaghosisTextBox = new TextBox();
            searchByDiaghosisBtn = new Button();
            searchByDate = new Button();
            dateTextBox = new DateTimePicker();
            cardRecordsGridView = new DataGridView();
            newRecBtn = new Button();
            mainLayout = new TableLayoutPanel();
            topLayout = new TableLayoutPanel();
            refreshButton = new Button();
            // 
            // newRecBtn
            // 
            newRecBtn.Dock = DockStyle.Bottom;
            this.newRecBtn.Location = new System.Drawing.Point(693, 94);
            this.newRecBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newRecBtn.Name = "newRecBtn";
            this.newRecBtn.Size = new System.Drawing.Size(236, 55);
            this.newRecBtn.TabIndex = 2;
            this.newRecBtn.Text = "Создать новую запись";
            this.newRecBtn.UseVisualStyleBackColor = true;
            this.newRecBtn.Click += new System.EventHandler(this.newRecBtn_Click);
            // 
            // groupBox2
            // 
            groupBox2.Dock = DockStyle.Fill;
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Controls.Add(this.cardRecordsGridView);
          
            this.groupBox2.Location = new System.Drawing.Point(23, 180);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(750, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список записей";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
            this.tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
            this.tableLayoutPanel3.Controls.Add(this.searchByDiaghosisBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.diaghosisTextBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new Size(350, 30);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // diaghosisTextBox
            //
            this.diaghosisTextBox.Size = new Size(245,32);
            this.dateTextBox.Dock = DockStyle.Fill;
            this.diaghosisTextBox.Name = "diaghosisTextBox";
            this.diaghosisTextBox.TabIndex = 0;
            // 
            // searchByDiaghosisBtn
            // 
            this.searchByDiaghosisBtn.Dock = DockStyle.Fill;     
            this.searchByDiaghosisBtn.Name = "searchByDiaghosisBtn";
            this.searchByDiaghosisBtn.Size = new System.Drawing.Size(105, 30);
            this.searchByDiaghosisBtn.TabIndex = 1;
            this.searchByDiaghosisBtn.Text = "Поиск по диагнозу";
            this.searchByDiaghosisBtn.UseVisualStyleBackColor = true;
            this.searchByDiaghosisBtn.Click += new System.EventHandler(this.searchByDiaghosisBtn_Click);           
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.searchByDate, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.dateTextBox, 0, 0);
            tableLayoutPanel4.Controls.Add(refreshButton, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(390, 20);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(350, 30);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // dateTextBox
            // 
            dateTextBox.Dock = DockStyle.Fill;
            this.dateTextBox.Name = "deteTextBox";
            this.dateTextBox.TabIndex = 0;
            this.dateTextBox.Size = new Size(245, 32);
            //
            // searchByDate
            // 
            this.searchByDate.Name = "searchByDate";
            this.searchByDate.Size = new Size(105, 30);
            this.searchByDate.TabIndex = 1;
            this.searchByDate.Text = "Поиск по дате";
            this.searchByDate.Click += SearchByDate_Click;
            //
            //refreshButton
            //
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new Size(105, 30);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Оновить список";
            this.refreshButton.Click += RefreshButton_Click; ;
           

            DataGridViewCell cell = new DataGridViewTextBoxCell();
            // 
            // recordNumberColumn
            // 
            this.recordNumberColumn.HeaderText = "Номер записи";
            this.recordNumberColumn.MinimumWidth = 6;
            this.recordNumberColumn.Name = "recordNumberColumn";
            this.recordNumberColumn.Width = 80;
            recordNumberColumn.CellTemplate = cell;
            // 
            // recordDateColumn
            // 
            this.recordDateColumn.HeaderText = "Дата";
            this.recordDateColumn.MinimumWidth = 6;
            this.recordDateColumn.Name = "recordDateColumn";
            this.recordDateColumn.Width = 80;
            recordDateColumn.CellTemplate = cell;
            // 
            // diaghosisColumn
            // 
            this.diaghosisColumn.HeaderText = "Диагноз";
            this.recordDateColumn.MinimumWidth = 6;
            this.recordDateColumn.Name = "recordDateColumn";
            this.diaghosisColumn.Width = 80;
            diaghosisColumn.CellTemplate = cell;
            // 
            // docterFioColumn
            // 
            this.docterFioColumn.HeaderText = "Врач";
            this.recordDateColumn.MinimumWidth = 6;
            this.recordDateColumn.Name = "recordDateColumn";
            this.docterFioColumn.Width = 80;
            docterFioColumn.CellTemplate = cell;
            // 
            // Open Record Button
            // 
            DataGridViewCell cell1 = new DataGridViewButtonCell();
            OpenButton.HeaderText = "Открыть запись";
            OpenButton.DefaultCellStyle.NullValue = "Открыть";
            OpenButton.CellTemplate = cell1;
            OpenButton.Name = "OpenButton";
  
            // cardRecordsGridView
            // 
            this.cardRecordsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardRecordsGridView.Location = new System.Drawing.Point(15, 70);
            this.cardRecordsGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardRecordsGridView.Name = "cardRecordsGridView";

            this.cardRecordsGridView.Size = new Size(750, 150);
            this.cardRecordsGridView.TabIndex = 2;
            cardRecordsGridView.Columns.Add(recordNumberColumn);
            cardRecordsGridView.Columns.Add(recordDateColumn);
            cardRecordsGridView.Columns.Add(diaghosisColumn);
            cardRecordsGridView.Columns.Add(docterFioColumn);
            cardRecordsGridView.Columns.Add(OpenButton);
            cardRecordsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cardRecordsGridView.AllowUserToAddRows = false;
            cardRecordsGridView.CellContentClick += CardRecordsGridView_CellContentClick;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(400, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Личная информация";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.42553F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.57447F));
            this.tableLayoutPanel2.Controls.Add(this.cardNumTextBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.phoneTextBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.addressTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.birthDateTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.fioTextBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 20);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 110);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cardNumTextBox
            // 
            this.cardNumTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardNumTextBox.Location = new System.Drawing.Point(149, 126);
            this.cardNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cardNumTextBox.Name = "cardNumTextBox";
            this.cardNumTextBox.Size = new System.Drawing.Size(329, 22);
            this.cardNumTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneTextBox.Location = new System.Drawing.Point(149, 95);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(329, 22);
            this.phoneTextBox.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Location = new System.Drawing.Point(149, 64);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(329, 22);
            this.addressTextBox.TabIndex = 5;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.birthDateTextBox.Location = new System.Drawing.Point(149, 33);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(329, 22);
            this.birthDateTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Номер карты:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Телефон:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Адрес:";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fioTextBox.Location = new System.Drawing.Point(149, 2);
            this.fioTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(329, 22);
            this.fioTextBox.TabIndex = 3;
            // 
            // mainLayout
            // 
            //this.mainLayout.Anchor = ((AnchorStyles.Top | AnchorStyles.Bottom)|(AnchorStyles.Left | AnchorStyles.Right));
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(topLayout, 0, 0);
            this.mainLayout.Controls.Add(groupBox2, 0, 1);
            this.mainLayout.Location = new Point(5, 23);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 2;
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            this.mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            this.mainLayout.Size = new Size(790, 400);
            this.mainLayout.TabIndex = 0;
            // 
            // topLayout
            // 
            this.topLayout.ColumnCount = 2;
            this.topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            this.topLayout.Controls.Add(groupBox1, 0, 0);
            this.topLayout.Controls.Add(newRecBtn, 1, 0);
            this.topLayout.Location = new Point(6, 24);
            this.topLayout.Name = "topLayout";
            this.topLayout.RowCount = 1;
            this.topLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.topLayout.Size = new Size(790, 200);
            this.topLayout.TabIndex = 0;

            //PatientPage
            this.AutoScroll = true;
            this.Controls.Add(mainLayout);
            this.Location = new Point(4, 22);
            this.Padding = new Padding(3);      
            this.Size = new Size(900, 400);
            this.UseVisualStyleBackColor = true;

            

            //add data in all fields

            thisPatient = patient;
            this.fioTextBox.Text = patient.FIO;
            birthDateTextBox.Text = patient.BirthDate.ToString("dd.MM.yyyy");
            addressTextBox.Text = patient.Address;
            phoneTextBox.Text = patient.Phone;
            cardNumTextBox.Text = patient.Card.CardNumber.ToString();
            cardID = patient.CardID;
            contex = new ClinicDBEntities();
            var records = contex.GetCardRecordsByCardId(cardID);
            gridSource(records.ToList());

        }

        private void CardRecordsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cardRecordsGridView.Columns[e.ColumnIndex].Name == "OpenButton")
            {
                int recordNumber = int.Parse(cardRecordsGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                int recID = contex.GetCardRecordID(cardID,recordNumber).FirstOrDefault().Value;
                RecordForm recordForm = new RecordForm(recID);
                recordForm.Visible = true;
            }
        }

        private void gridSource(List<CardRecordsWithDoctorNameView> source)
        {
            if (cardRecordsGridView.Rows.Count != 0) cardRecordsGridView.Rows.Clear();
            int rowIndex = 0;
            foreach (CardRecordsWithDoctorNameView cr in source)
            {
                cardRecordsGridView.Rows.Add();
                cardRecordsGridView.Rows[rowIndex].Cells[0].Value = cr.RecordNumber.ToString();
                cardRecordsGridView.Rows[rowIndex].Cells[1].Value = cr.RecordDate.ToString("dd.MM.yyyy");
                cardRecordsGridView.Rows[rowIndex].Cells[2].Value = cr.Diaghosis;
                cardRecordsGridView.Rows[rowIndex].Cells[3].Value = cr.FIO;
                rowIndex++;
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            cardRecordsGridView.Rows.Clear();
            contex = new ClinicDBEntities();
            var records = contex.GetCardRecordsByCardId(cardID);
            gridSource(records.ToList());
        }

        private void SearchByDate_Click(object sender, EventArgs e)
        {
            DateTime date = dateTextBox.Value;
            var seachResults = contex.GetRecordByDate(cardID,date);
            gridSource(seachResults.ToList());
        }

        private void newRecBtn_Click(object sender, EventArgs e)
        {
            NewRecordForm newRecordForm = new NewRecordForm(thisPatient.Card);
            newRecordForm.Visible = true;
        }

        private void searchByDiaghosisBtn_Click(object sender, EventArgs e)
        {
            string diaghosisText = diaghosisTextBox.Text;
            var seachResults = contex.GetRecordByDiaghosis(cardID, diaghosisText);
            gridSource(seachResults.ToList());
        }
    }
}
