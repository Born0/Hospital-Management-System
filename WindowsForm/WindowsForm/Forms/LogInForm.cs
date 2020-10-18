using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Entities;
using WindowsForm.Forms;
using WindowsForm.Services;

namespace WindowsForm
{
    public partial class LogInForm : MetroFramework.Forms.MetroForm
    {
        public LogInForm()
        {
            InitializeComponent();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            textBox2.Text = String.Empty;
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            LoginService ls = new LoginService();
            Login temp = new Login();
            temp.UserName = textBox1.Text;
            temp.Passsword = textBox2.Text;
            Login eLog = new Login();
            eLog = ls.LoginValidation(temp);
            if (eLog.UserType == 1)
            {
                Admin adminTemp = new Admin();
                adminTemp.Phone = textBox1.Text;
                Admin admin = new Admin();
                AdminServices adminServices = new AdminServices();
                admin = adminServices.Get(adminTemp);

                AdminForm adminForm = new AdminForm(admin);
                adminForm.Show();
                this.Visible = false;
            }
            else if (eLog.UserType == 2)
            {
                Doctor doctorTemp = new Doctor();
                doctorTemp.Phone = textBox1.Text;
                Doctor doctor = new Doctor();
                DoctorService doctorService = new DoctorService();
                doctor = doctorService.Get(doctorTemp);

                DoctorForm doctorForm = new DoctorForm(doctor);
                doctorForm.Show();
                this.Visible = false;
            }
            else if (eLog.UserType == 3)
            {
                Staff staffTemp = new Staff();
                staffTemp.Phone = textBox1.Text;
                Staff staff = new Staff();
                StaffServices staffServices = new StaffServices();
                staff = staffServices.Get(staffTemp);

                StaffForm staffForm = new StaffForm(staff);
                staffForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("User Not Found");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Contact Admin");
        }
    }
}
