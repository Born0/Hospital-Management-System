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

namespace WindowsForm.Control_Ui.Doctor_Panel_Ui
{
    public partial class DoctorPanelControl : UserControl
    {
        public DoctorPanelControl()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            addDoctorControl1.Dock = DockStyle.Fill;
            addDoctorControl1.Visible = true;

            doctorListGridView.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addDoctorControl1.Visible = false;
            doctorListGridView.Visible = true;

            DoctorService doctorService = new DoctorService();
            
            doctorListGridView.DataSource = doctorService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorService doctorService = new DoctorService();
            Doctor doctor = new Doctor();
            doctor.Name = textBox2.Text;
            doctor.Gender = textBox6.Text;
            doctor.Address = textBox3.Text;
            doctor.Phone = textBox7.Text;
            doctor.Salary = Convert.ToDouble(textBox5.Text);
            bool check = doctorService.Update(doctor);
            if (check)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error Occured !");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DoctorService doctorServices = new DoctorService();
            Doctor temp = new Doctor();
            temp.Phone = textBox1.Text;
            bool check = doctorServices.Delete(temp);
            if (check)
            {
                MessageBox.Show("Doctor Deleted");
            }
            else
            {
                MessageBox.Show("Error Occured !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DoctorService doctorService = new DoctorService();
            Doctor temp = new Doctor();
            temp.Phone = textBox1.Text;
            Doctor doctor = new Doctor();
            doctor = doctorService.Get(temp);
            if (doctor == null)
            {
                MessageBox.Show("Not Found !");
            }
            else
            {
                textBox2.Text = doctor.Name;
                textBox6.Text = doctor.Gender;
                textBox3.Text = doctor.Address;
                textBox7.Text = doctor.Phone;
                textBox5.Text = doctor.Salary.ToString();
            }

        }
    }
}
