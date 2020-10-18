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
    public partial class CheckOutHistoryControl : UserControl
    {
        public CheckOutHistoryControl()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            PatientServices patientServices = new PatientServices();
            dataGridView1.DataSource = patientServices.GetAllPrevious();
        }

        private void serachBtn_Click(object sender, EventArgs e)
        {
            Patient temp = new Patient();
            temp.Id = Convert.ToInt32(textBox1.Text);
            PatientServices patientServices = new PatientServices();
            Patient patient = new Patient();
            patient = patientServices.Get(temp);
            if(patient.Status!=0)
            {

                textBox2.Text = "";
                textBox8.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                textBox12.Text = "";
                MessageBox.Show("No data");
            }
            else if (patient != null)
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
                textBox10.Text = patient.TotalCost.ToString();

                textBox11.Text = patient.RoomNumber.ToString();
                textBox12.Text = patient.Seat.ToString();


                comboBox1.Text = patient.ReleaseCondition;
                comboBox1.Enabled = true;


            }
        }
    }
}
