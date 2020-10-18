using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Services;
using WindowsForm.Entities;

namespace WindowsForm
{
    public partial class PatientInfoControl : UserControl
    {
        public PatientInfoControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Visible = true;
         


            List<Patient> patients = new List<Patient>();
            PatientServices patientServices = new PatientServices();
            patients = patientServices.GetAllCurrent();
            dataGridView1.DataSource = patients;

            label14.Hide();
            label15.Hide();
            textBox10.Hide();
            textBox11.Hide();




        }

        private void extraServicesBtn_Click(object sender, EventArgs e)
        {

            dataGridView1.Visible = false;

            label14.Show();
            label15.Show();
            textBox10.Show();
            textBox11.Show();

            if (textBox1.Text == "")
            {
                MessageBox.Show("provide Id");
            }
            else
            {
                Patient temp = new Patient();
                temp.Id = Convert.ToInt32(textBox1.Text);

                Patient patient = new Patient();
                PatientServices patientServices = new PatientServices();
                patient = patientServices.Get(temp);
                if (patient.OT == 1)
                {
                    textBox11.Text = "YES";
                }
                else
                    textBox11.Text = "NO";

                textBox10.Text = patient.ExtraServices;
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patient temp = new Patient();

      


            temp.Id = Convert.ToInt32 (textBox1.Text);
            PatientServices patientServices = new PatientServices();
            Patient  patient = new Patient();
            patient = patientServices.Get(temp);
            if(patient.Status!=1)
            {
                textBox2.Text = "";
                textBox8.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";




                MessageBox.Show("No data"); 
            }
            else if(patient!=null)
            {
                textBox2.Text = patient.Name;
                textBox8.Text = patient.Date;
                textBox3.Text = patient.Gender;
                textBox4.Text = patient.Age.ToString();
                textBox5.Text = patient.Phone;
                textBox6.Text = patient.Consultant;
                textBox7.Text = patient.Address;
                textBox9.Text = patient.Emergency;
                
                comboBox2.Text = patient.ReadyToRelease;
                if (patient.ReadyToRelease == "Yes")
                {
                    comboBox1.Text = patient.ReleaseCondition;
                }
                else
                {
                    comboBox1.Enabled = false;
                }



            }
        }
    }
}
