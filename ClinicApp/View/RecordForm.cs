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
    public partial class RecordForm : Form
    {
        ClinicDBEntities contex;
        public RecordForm(int recID)
        {
            InitializeComponent();
            contex = new ClinicDBEntities();
            foreach (CardRecord cardRecord in contex.CardRecord.ToList())
            {
                if (cardRecord.Id == recID)
                {
                    this.Text = "Запись № " + cardRecord.RecordNumber.ToString() + " карты "+ cardRecord.Card.CardNumber.ToString();
                    cardNumberLbl.Text = cardRecord.Card.CardNumber.ToString();
                    cardRecordLbl.Text = cardRecord.RecordNumber.ToString();
                    dataLbl.Text = cardRecord.RecordDate.ToString("dd.MM.yyyy");
                    doctorTextBox.Text = cardRecord.ClinicEmployee.FIO;
                    diaghosisTextBox.Text = cardRecord.Diaghosis;
                    addInfoTextBox.Text = cardRecord.AddInfo;
                    int i = 0;
                    foreach (CardRecordMedicine cm in cardRecord.CardRecordMedicine)
                    {
                        medicineGridView.Rows.Add();
                        medicineGridView.Rows[i].Cells[0].Value = cm.Medicine.MedicineName;
                        medicineGridView.Rows[i].Cells[1].Value = cm.Medicine.OneTimeQuantity;
                        medicineGridView.Rows[i].Cells[2].Value = cm.Medicine.DayTimes;
                        medicineGridView.Rows[i].Cells[3].Value = cm.Medicine.Duration;
                        i++; 
                    }
                    int j = 0;
                    foreach (CardRecordMedicalTest cm in cardRecord.CardRecordMedicalTest)
                    {
                        testsGridView.Rows.Add();
                        testsGridView.Rows[j].Cells[0].Value = cm.MedicalTest.TestName;
                        testsGridView.Rows[j].Cells[1].Value = cm.MedicalTest.Price;
                        testsGridView.Rows[j].Cells[2].Value = cm.MedicalTest.Info;
                        j++;
                    }
                }
            }
        }
    }
}
