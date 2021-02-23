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
    public partial class AddNewPatientForm : Form
    {
        Card curCard;
        public AddNewPatientForm(Card card)
        {
            InitializeComponent();
            curCard = card;
            cardNumberLbl.Text = curCard.CardNumber.ToString();
        }

        private void addNewRecordBtn_Click(object sender, EventArgs e)
        {
            if (curCard.Patient.Count != 0)
            {
                NewRecordForm newRecordForm = new NewRecordForm(curCard);
                newRecordForm.Visible = true;
            }
            else
                MessageBox.Show("Сохраните пациента!", "Сообщение", MessageBoxButtons.OK);
        }
        private void savePatientBtn_Click(object sender, EventArgs e)
        {
            try
            {
                savePatientAndCard();               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Пациент уже сохраненн!");
            }
        }
        private void savePatientAndCard()
        {
            try
            {
                if (fioTextBox.Text != "" && addressTextBox.Text != "" && phoneTextBox.Text != "")
                {
                    ClinicDBEntities contex = new ClinicDBEntities();
                    contex.Card.Add(curCard);
                    Patient patient = new Patient();
                    patient.FIO = fioTextBox.Text;
                    patient.BirthDate = birthDateTimePicker.Value;
                    patient.Address = addressTextBox.Text;
                    patient.Phone = phoneTextBox.Text;
                    contex.Patient.Add(patient);
                    contex.SaveChanges();
                    MessageBox.Show("Успешно сохранено!", "Сообщение", MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Все поля обязательны для заполнения!!!");
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Заполните все поля верно!!!" + ex.Message);
            }
        }
    }
}
