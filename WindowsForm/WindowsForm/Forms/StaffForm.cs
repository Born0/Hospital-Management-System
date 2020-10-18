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

namespace WindowsForm
{
    public partial class StaffForm : Form
    {
        public Staff staff;
        public StaffForm( Staff staff)
        {
            InitializeComponent();
            this.staff = new Staff();
            this.staff = staff;
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            sidePanel.Height = patientInfoBtn.Height;
            sidePanel.Top = patientInfoBtn.Top;
           // patientInfoControl1.BringToFront();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = patientRegBtn.Height;
            sidePanel.Top = patientRegBtn.Top;
            //patientRegistration1.Dock = DockStyle.Fill;
            //patientRegistration1.Visible = true;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = checkOutBtn.Height;
            sidePanel.Top = checkOutBtn.Top;
        }

        private void checkOutHisBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = checkOutHisBtn.Height;
            sidePanel.Top = checkOutHisBtn.Top;

        }

        private void patientRegBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = patientRegBtn.Height;
            sidePanel.Top = patientRegBtn.Top;
            patientRegistrationControl1.Dock = DockStyle.Fill;
            patientRegistrationControl1.Visible = true;
            patientInfoControl1.Visible = false;
            checkOutControl1.Visible = false;
            checkOutHistoryControl1.Visible = false;
            changePasswordControl1.Visible = false;


        }

        private void patientInfoBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = patientInfoBtn.Height;
            sidePanel.Top = patientInfoBtn.Top;
            patientInfoControl1.Dock = DockStyle.Fill;
            patientRegistrationControl1.Visible = false;
            patientInfoControl1.Visible = true;
            checkOutControl1.Visible = false;
            checkOutHistoryControl1.Visible = false;
            changePasswordControl1.Visible = false;


        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = checkOutBtn.Height;
            sidePanel.Top = checkOutBtn.Top;
            checkOutControl1.Dock = DockStyle.Fill;
            checkOutControl1.Visible = true;
            patientRegistrationControl1.Visible = false;
            patientInfoControl1.Visible = false;
            checkOutHistoryControl1.Visible = false;
            changePasswordControl1.Visible = false;




        }

        private void checkOutHisBtn_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = checkOutHisBtn.Height;
            sidePanel.Top = checkOutHisBtn.Top;
            checkOutControl1.Visible = false;
            patientRegistrationControl1.Visible = false;
            patientInfoControl1.Visible = false;
            checkOutHistoryControl1.Dock = DockStyle.Fill;
            checkOutHistoryControl1.Visible = true;

            changePasswordControl1.Visible = false;

        }

       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = messageBtn.Height;
            sidePanel.Top = messageBtn.Top;
            changePasswordControl1.Dock = DockStyle.Fill;
            changePasswordControl1.Visible = true;

            changePasswordControl1.Staff1 = staff;

            patientRegistrationControl1.Visible = false;
            patientInfoControl1.Visible = false;
            checkOutControl1.Visible = false;
            checkOutHistoryControl1.Visible = false;
            
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogInForm l1 = new LogInForm();
            l1.Visible = true;
        }
    }
}
