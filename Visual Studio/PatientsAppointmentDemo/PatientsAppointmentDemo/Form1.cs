using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientsAppointmentDemo
{
    public partial class Form1 : Form
    {

        Appointment app = new Appointment();

        public Form1()
        {
            InitializeComponent();
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string genderValue = genderComboBox.SelectedItem.ToString();

            bool isMale = false;
            if (genderValue.Equals("male"))
            {
                isMale = true;
            }

            Patient p = new Patient(name, address, isMale);

            app.addPatient(p);

            WaitingList.DataSource = app.getAllWaitingPatient().ToList();


        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            Patient p = app.seeDoctor();
            SeenDoctor.Items.Add(p);

        }
    }
}
