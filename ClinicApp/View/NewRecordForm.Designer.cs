namespace ClinicApp.View
{
    partial class NewRecordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cardNumberLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cardRecordLbl = new System.Windows.Forms.Label();
            this.cardRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.dataLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.addInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.diaghosisTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addMedicineBtn = new System.Windows.Forms.Button();
            this.medicineGridView = new System.Windows.Forms.DataGridView();
            this.medicineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oneTimeQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayTimesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.medicineComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addTestBtn = new System.Windows.Forms.Button();
            this.testsGridView = new System.Windows.Forms.DataGridView();
            this.testName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtnColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.testsComboBox = new System.Windows.Forms.ComboBox();
            this.saveRecordBtn = new System.Windows.Forms.Button();
            this.medicalTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardRecordsWithDoctorNameViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cardRecordBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicineGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalTestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardRecordsWithDoctorNameViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ карты:";
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Location = new System.Drawing.Point(116, 29);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(46, 17);
            this.cardNumberLbl.TabIndex = 1;
            this.cardNumberLbl.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "№ записи:";
            // 
            // cardRecordLbl
            // 
            this.cardRecordLbl.AutoSize = true;
            this.cardRecordLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardRecordBindingSource, "RecordNumber", true));
            this.cardRecordLbl.Location = new System.Drawing.Point(112, 68);
            this.cardRecordLbl.Name = "cardRecordLbl";
            this.cardRecordLbl.Size = new System.Drawing.Size(46, 17);
            this.cardRecordLbl.TabIndex = 3;
            this.cardRecordLbl.Text = "label4";
            // 
            // cardRecordBindingSource
            // 
            this.cardRecordBindingSource.DataSource = typeof(ClinicApp.Model.CardRecord);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата:";
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardRecordBindingSource, "RecordDate", true));
            this.dataLbl.Location = new System.Drawing.Point(629, 29);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(46, 17);
            this.dataLbl.TabIndex = 5;
            this.dataLbl.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Врач:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.doctorComboBox);
            this.groupBox1.Controls.Add(this.addInfoTextBox);
            this.groupBox1.Controls.Add(this.diaghosisTextBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(43, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 441);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(23, 39);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(289, 24);
            this.doctorComboBox.TabIndex = 12;
            // 
            // addInfoTextBox
            // 
            this.addInfoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardRecordBindingSource, "AddInfo", true));
            this.addInfoTextBox.Location = new System.Drawing.Point(23, 177);
            this.addInfoTextBox.Name = "addInfoTextBox";
            this.addInfoTextBox.Size = new System.Drawing.Size(289, 243);
            this.addInfoTextBox.TabIndex = 11;
            this.addInfoTextBox.Text = "";
            // 
            // diaghosisTextBox
            // 
            this.diaghosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cardRecordBindingSource, "Diaghosis", true));
            this.diaghosisTextBox.Location = new System.Drawing.Point(23, 110);
            this.diaghosisTextBox.Name = "diaghosisTextBox";
            this.diaghosisTextBox.Size = new System.Drawing.Size(289, 22);
            this.diaghosisTextBox.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Допалнительная информация:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Диагноз:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.addMedicineBtn);
            this.groupBox2.Controls.Add(this.medicineGridView);
            this.groupBox2.Controls.Add(this.medicineComboBox);
            this.groupBox2.Location = new System.Drawing.Point(413, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лекарства";
            // 
            // addMedicineBtn
            // 
            this.addMedicineBtn.Location = new System.Drawing.Point(344, 35);
            this.addMedicineBtn.Name = "addMedicineBtn";
            this.addMedicineBtn.Size = new System.Drawing.Size(168, 24);
            this.addMedicineBtn.TabIndex = 2;
            this.addMedicineBtn.Text = "Назначить лекарство";
            this.addMedicineBtn.UseVisualStyleBackColor = true;
            this.addMedicineBtn.Click += new System.EventHandler(this.addMedicineBtn_Click);
            // 
            // medicineGridView
            // 
            this.medicineGridView.AllowUserToAddRows = false;
            this.medicineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.medicineGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.medicineGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.medicineGridView.ColumnHeadersHeight = 29;
            this.medicineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medicineNameDataGridViewTextBoxColumn,
            this.oneTimeQuantityDataGridViewTextBoxColumn,
            this.dayTimesDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.deleteColumn});
            this.medicineGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cardRecordBindingSource, "CardRecordMedicine", true));
            this.medicineGridView.Location = new System.Drawing.Point(20, 81);
            this.medicineGridView.Name = "medicineGridView";
            this.medicineGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.medicineGridView.RowTemplate.Height = 24;
            this.medicineGridView.Size = new System.Drawing.Size(676, 107);
            this.medicineGridView.TabIndex = 1;
            // 
            // medicineNameDataGridViewTextBoxColumn
            // 
            this.medicineNameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.medicineNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.medicineNameDataGridViewTextBoxColumn.Name = "medicineNameDataGridViewTextBoxColumn";
            this.medicineNameDataGridViewTextBoxColumn.Width = 77;
            // 
            // oneTimeQuantityDataGridViewTextBoxColumn
            // 
            this.oneTimeQuantityDataGridViewTextBoxColumn.HeaderText = "К-во прийома";
            this.oneTimeQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oneTimeQuantityDataGridViewTextBoxColumn.Name = "oneTimeQuantityDataGridViewTextBoxColumn";
            this.oneTimeQuantityDataGridViewTextBoxColumn.Width = 127;
            // 
            // dayTimesDataGridViewTextBoxColumn
            // 
            this.dayTimesDataGridViewTextBoxColumn.HeaderText = "К-во раз/день";
            this.dayTimesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dayTimesDataGridViewTextBoxColumn.Name = "dayTimesDataGridViewTextBoxColumn";
            this.dayTimesDataGridViewTextBoxColumn.Width = 128;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.Width = 171;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "Удалить";
            this.deleteColumn.MinimumWidth = 6;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Width = 92;
            // 
            // medicineComboBox
            // 
            this.medicineComboBox.FormattingEnabled = true;
            this.medicineComboBox.Location = new System.Drawing.Point(20, 35);
            this.medicineComboBox.Name = "medicineComboBox";
            this.medicineComboBox.Size = new System.Drawing.Size(286, 24);
            this.medicineComboBox.Sorted = true;
            this.medicineComboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.addTestBtn);
            this.groupBox3.Controls.Add(this.testsGridView);
            this.groupBox3.Controls.Add(this.testsComboBox);
            this.groupBox3.Location = new System.Drawing.Point(413, 355);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(716, 212);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Анализы";
            // 
            // addTestBtn
            // 
            this.addTestBtn.Location = new System.Drawing.Point(344, 37);
            this.addTestBtn.Name = "addTestBtn";
            this.addTestBtn.Size = new System.Drawing.Size(168, 24);
            this.addTestBtn.TabIndex = 3;
            this.addTestBtn.Text = "Назначить анализ";
            this.addTestBtn.UseVisualStyleBackColor = true;
            this.addTestBtn.Click += new System.EventHandler(this.addTestBtn_Click);
            // 
            // testsGridView
            // 
            this.testsGridView.AllowUserToAddRows = false;
            this.testsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.testsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testName,
            this.priceColumn,
            this.infoColumn,
            this.deleteBtnColumn});
            this.testsGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.cardRecordBindingSource, "CardRecordMedicalTest", true));
            this.testsGridView.Location = new System.Drawing.Point(20, 81);
            this.testsGridView.Name = "testsGridView";
            this.testsGridView.RowHeadersWidth = 51;
            this.testsGridView.RowTemplate.Height = 24;
            this.testsGridView.Size = new System.Drawing.Size(646, 110);
            this.testsGridView.TabIndex = 2;
            // 
            // testName
            // 
            this.testName.HeaderText = "Название";
            this.testName.MinimumWidth = 6;
            this.testName.Name = "testName";
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Цена";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            // 
            // infoColumn
            // 
            this.infoColumn.HeaderText = "Описание";
            this.infoColumn.MinimumWidth = 6;
            this.infoColumn.Name = "infoColumn";
            // 
            // deleteBtnColumn
            // 
            this.deleteBtnColumn.HeaderText = "Удалить";
            this.deleteBtnColumn.MinimumWidth = 6;
            this.deleteBtnColumn.Name = "deleteBtnColumn";
            this.deleteBtnColumn.Text = "Удалить";
            // 
            // testsComboBox
            // 
            this.testsComboBox.FormattingEnabled = true;
            this.testsComboBox.Location = new System.Drawing.Point(20, 38);
            this.testsComboBox.Name = "testsComboBox";
            this.testsComboBox.Size = new System.Drawing.Size(286, 24);
            this.testsComboBox.Sorted = true;
            this.testsComboBox.TabIndex = 1;
            // 
            // saveRecordBtn
            // 
            this.saveRecordBtn.Location = new System.Drawing.Point(387, 597);
            this.saveRecordBtn.Name = "saveRecordBtn";
            this.saveRecordBtn.Size = new System.Drawing.Size(265, 56);
            this.saveRecordBtn.TabIndex = 10;
            this.saveRecordBtn.Text = "Сохранить запись";
            this.saveRecordBtn.UseVisualStyleBackColor = true;
            this.saveRecordBtn.Click += new System.EventHandler(this.saveRecordBtn_Click);
            // 
            // medicalTestBindingSource
            // 
            this.medicalTestBindingSource.DataSource = typeof(ClinicApp.Model.MedicalTest);
            // 
            // medicineBindingSource
            // 
            this.medicineBindingSource.DataSource = typeof(ClinicApp.Model.Medicine);
            // 
            // cardRecordsWithDoctorNameViewBindingSource
            // 
            this.cardRecordsWithDoctorNameViewBindingSource.DataSource = typeof(ClinicApp.Model.CardRecordsWithDoctorNameView);
            // 
            // NewRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 680);
            this.Controls.Add(this.saveRecordBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cardRecordLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardNumberLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление новой записи в карту";
            this.Load += new System.EventHandler(this.NewRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardRecordBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicineGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalTestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardRecordsWithDoctorNameViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cardNumberLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cardRecordLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView medicineGridView;
        private System.Windows.Forms.ComboBox medicineComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource medicineBindingSource;
        private System.Windows.Forms.DataGridView testsGridView;
        private System.Windows.Forms.BindingSource medicalTestBindingSource;
        private System.Windows.Forms.ComboBox testsComboBox;
        private System.Windows.Forms.Button saveRecordBtn;
        private System.Windows.Forms.RichTextBox addInfoTextBox;
        private System.Windows.Forms.TextBox diaghosisTextBox;
        private System.Windows.Forms.Button addMedicineBtn;
        private System.Windows.Forms.Button addTestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oneTimeQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayTimesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn infoColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtnColumn;
        private System.Windows.Forms.BindingSource cardRecordsWithDoctorNameViewBindingSource;
        private System.Windows.Forms.BindingSource cardRecordBindingSource;
        private System.Windows.Forms.ComboBox doctorComboBox;
    }
}