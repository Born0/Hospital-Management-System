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

namespace WindowsForm.Control_Ui.Doctor_Panel_Ui
{
    public partial class PatientInfoForDoctorControl : UserControl
    {
        public Doctor doctor;

        public PatientInfoForDoctorControl()
        {
            InitializeComponent();
            
        }

        public PatientInfoForDoctorControl( Doctor doctor)
        {
            InitializeComponent();
            this.doctor = new Doctor();
            this.doctor = doctor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Visible = true;
            //extraServicesControl1.Visible = false;
            comboBox3.Hide();
            label15.Hide();
            checkedListBox1.Hide();
            label14.Hide();
            button3.Hide();
            button4.Hide();

            List<Patient> patients = new List<Patient>();
            PatientServices patientServices = new PatientServices();
            patients = patientServices.GetAllCurrent();

            foreach (Patient item in patients.ToList())
            {
               // MessageBox.Show(doctor.Name + ":" + doctor.Phone);
                if(item.Consultant.Equals(doctor.Name+":"+doctor.Phone)==false)
                {
                    patients.Remove(item);
                }
            }

            dataGridView1.DataSource = patients;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Hide();
            label15.Hide();
            checkedListBox1.Hide();
            label14.Hide();
            button3.Hide();
            button4.Hide();



            Patient temp = new Patient();
            temp.Id = Convert.ToInt32(textBox1.Text);
            PatientServices patientServices = new PatientServices();
            Patient patient = new Patient();
            patient = patientServices.Get(temp);
            string consult = doctor.Name + ":" + doctor.Phone;
            if ( patient.Status != 1 )
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
            else if (patient != null && patient.Consultant.Equals(consult))
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
                comboBox1.Text = patient.ReleaseCondition;
              

            }
            else
            {

                textBox2.Text = "";
                textBox8.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";
                MessageBox.Show("NO Data");
            }
        }

        private void extraServicesBtn_Click(object sender, EventArgs e)
        {
            

            dataGridView1.Visible = false;
            comboBox3.Text = "";
            comboBox3.Show();
            label15.Show();
            checkedListBox1.Show();
            label14.Show();
            button3.Show();
            button4.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {

            PatientServices patientServices = new PatientServices();
            Patient temp = new Patient();
            temp.Id = Convert.ToInt32(textBox1.Text);

            Patient patient = new Patient();
            patient = patientServices.Get(temp);

            List<string> test = new List<string>();

            foreach (string item in checkedListBox1.CheckedItems)
            {
                test.Add(item);
            }
            string testList="";
            double tcost = patient.TotalCost;
            foreach(string item in test)
            {
                testList += item + ",";
                tcost += 500;


            }

           
           // patient.Id = Convert.ToInt32(textBox1.Text);
            if (comboBox3.Text.Equals("YES"))
            {
                patient.OT =1;
               tcost+= 2000;
            }
            else
            patient.OT = 0;

            patient.ExtraServices = testList;
            patient.TotalCost = tcost;

            
           bool check= patientServices.ExtraServicesUpdate(patient);

            if (check)
            {
                MessageBox.Show("Extra services added.");
            }

            else
                MessageBox.Show("error occured.");

        }

        private void button5_Click(object sender, EventArgs e)
        {

            Patient temp = new Patient();
            temp.Id = Convert.ToInt32(textBox1.Text);
            temp.ReadyToRelease = comboBox2.Text;
            temp.ReleaseCondition = comboBox1.Text;


            PatientServices patientServices = new PatientServices();
            bool check=patientServices.ConditionUpdate(temp);
            if (check)
            {
                MessageBox.Show("Updated..");
            }
            else
                MessageBox.Show("error");
        }
    }
}
