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
    public partial class AddDoctorControl : UserControl
    {
        public AddDoctorControl()
        {
            InitializeComponent();
        }

        private void AddDoctorControl_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" ||
               textBox5.Text == "" || comboBox1.Text == "" || textBox8.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Provide all information...");

            }
            else
            {

                Doctor edoctor = new Doctor();
                edoctor.Name = textBox2.Text;

                edoctor.Gender = comboBox1.Text;
                edoctor.Phone = textBox4.Text;
                edoctor.Address = textBox3.Text;
                edoctor.Dob = textBox8.Text;
                edoctor.Salary = Convert.ToDouble(textBox7.Text);
                edoctor.Password = textBox1.Text;
                edoctor.WId = Convert.ToInt32(textBox5.Text);
                edoctor.NotificationCount = 0;
                edoctor.Notfication = null;

                DoctorService doctorServices = new DoctorService();
                bool check = doctorServices.AddDoctor(edoctor);
                if (check)
                {
                    MessageBox.Show("Doctor Added");
                }
                else
                {
                    MessageBox.Show("Error Occured !");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }
    }
}
