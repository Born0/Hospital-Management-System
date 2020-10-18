using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Entities;
using WindowsForm.Services;

namespace WindowsForm.Control_Ui
{
    public partial class PrescriptionControl : UserControl
    {
        public Doctor doctor;

        public PrescriptionControl()
        {
            InitializeComponent();
        }

        public PrescriptionControl( Doctor doctor)
        {
            InitializeComponent();
            this.doctor = new Doctor();
            this.doctor = doctor;
        }

        private void extraServicesBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient temp = new Patient();
            temp.Id = Convert.ToInt32(textBox1.Text);
            PatientServices patientServices = new PatientServices();
            Patient patient = new Patient();
            patient = patientServices.Get(temp);

            string consult = this.doctor.Name + ":" + this.doctor.Phone;
            if (patient.Status != 1)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("NO Data");
            }
            else if (patient != null && patient.Consultant.Equals(consult))
            {
                textBox2.Text = patient.Name;
                textBox3.Text = patient.Gender;
                textBox4.Text = patient.Age.ToString();
            }
            else
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("NO Data");
            }

            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patient temp = new Patient();
            temp.Id = Convert.ToInt32(textBox1.Text);
            PatientServices patientServices = new PatientServices();
            Patient patient = new Patient();
            patient = patientServices.Get(temp);
            patient.Prescription = textBox5.Text;

            bool check = patientServices.PrescriptionUpdate(patient);
            if (check)
            {
                MessageBox.Show("Successfull");
            }
            else
                MessageBox.Show("Error Occured");






        }
    }
}
