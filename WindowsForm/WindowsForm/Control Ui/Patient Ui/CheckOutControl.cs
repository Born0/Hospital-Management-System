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
    public partial class CheckOutControl : UserControl
    {
        public CheckOutControl()
        {
            InitializeComponent();
            checkOutBtn.Enabled = false;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //List<Patient> patients = new List<Patient>();
            PatientServices patientServices = new PatientServices();
           dataGridView1.DataSource = patientServices.GetAllCurrent();    
        }

        private void serachBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("provide Id");
            }
            else
            {
                
                Patient temp = new Patient();
                temp.Id = Convert.ToInt32(textBox1.Text);
                PatientServices patientServices = new PatientServices();
                Patient patient = new Patient();
                patient = patientServices.Get(temp);

                if (patient.Status != 1)
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

                    //MessageBox.Show(ready);
                    if (patient.ReadyToRelease.CompareTo("YES") == 1)
                    {
                        comboBox1.Enabled = false;
                        comboBox1.Text = patient.ReleaseCondition;
                        comboBox1.Enabled = true;
                        checkOutBtn.Enabled = true;

                    }
                    else
                    {
                        comboBox1.Enabled = false;
                        checkOutBtn.Enabled = false;

                    }
                }
                else
                {
                    MessageBox.Show("No data");
                }
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            patient.Seat = Convert.ToInt32 (textBox12.Text);
            patient.Id =Convert.ToInt32 (textBox1.Text);
            patient.Status = 0;
            patient.RoomNumber =Convert.ToInt32 (textBox11.Text);
            patient.CheckOutDate = DateTime.Today.ToString();
            PatientServices patientServices = new PatientServices();
            bool check = patientServices.Update(patient);
            if(check)
            {
                MessageBox.Show("Checked Out ");

                printDialog1.Document = printDocument1;
                if(printDialog1.ShowDialog()==DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            e.Graphics.DrawString("Hospital Management System", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 250, 75);

            e.Graphics.DrawString("Name:"+textBox2.Text+"\r\n", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 150, 125);
            e.Graphics.DrawString("Age:"+textBox4.Text+"\r\n", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 150, 160);
            e.Graphics.DrawString("Gender:"+textBox3.Text + "\r\n", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, 150, 195);
            e.Graphics.DrawString("Total Cost:" + textBox10.Text+"BDT " + "\r\n", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 150, 240);

        }
    }
}
