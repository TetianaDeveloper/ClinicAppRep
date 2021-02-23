namespace ClinicApp.View
{
    partial class AddNewPatientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.savePatientBtn = new System.Windows.Forms.Button();
            this.addNewRecordBtn = new System.Windows.Forms.Button();
            this.cardNumberLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Телефон:";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(126, 88);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(499, 22);
            this.fioTextBox.TabIndex = 5;
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Location = new System.Drawing.Point(167, 141);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.birthDateTimePicker.TabIndex = 6;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(126, 197);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(516, 22);
            this.addressTextBox.TabIndex = 7;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(126, 252);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(516, 22);
            this.phoneTextBox.TabIndex = 8;
            // 
            // savePatientBtn
            // 
            this.savePatientBtn.Location = new System.Drawing.Point(403, 389);
            this.savePatientBtn.Name = "savePatientBtn";
            this.savePatientBtn.Size = new System.Drawing.Size(211, 54);
            this.savePatientBtn.TabIndex = 9;
            this.savePatientBtn.Text = "Сохранить";
            this.savePatientBtn.UseVisualStyleBackColor = true;
            this.savePatientBtn.Click += new System.EventHandler(this.savePatientBtn_Click);
            // 
            // addNewRecordBtn
            // 
            this.addNewRecordBtn.Location = new System.Drawing.Point(99, 389);
            this.addNewRecordBtn.Name = "addNewRecordBtn";
            this.addNewRecordBtn.Size = new System.Drawing.Size(210, 54);
            this.addNewRecordBtn.TabIndex = 10;
            this.addNewRecordBtn.Text = "Добавить запись в карту";
            this.addNewRecordBtn.UseVisualStyleBackColor = true;
            this.addNewRecordBtn.Click += new System.EventHandler(this.addNewRecordBtn_Click);
            // 
            // cardNumberLbl
            // 
            this.cardNumberLbl.AutoSize = true;
            this.cardNumberLbl.Location = new System.Drawing.Point(123, 33);
            this.cardNumberLbl.Name = "cardNumberLbl";
            this.cardNumberLbl.Size = new System.Drawing.Size(46, 17);
            this.cardNumberLbl.TabIndex = 11;
            this.cardNumberLbl.Text = "label6";
            // 
            // AddNewPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 526);
            this.Controls.Add(this.cardNumberLbl);
            this.Controls.Add(this.addNewRecordBtn);
            this.Controls.Add(this.savePatientBtn);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация нового пациента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button savePatientBtn;
        private System.Windows.Forms.Button addNewRecordBtn;
        private System.Windows.Forms.Label cardNumberLbl;
    }
}