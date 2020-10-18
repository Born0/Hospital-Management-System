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

namespace WindowsForm.Forms
{
    public partial class AdminForm : Form
    {
        public Admin admin;
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = new Admin();
            this.admin = admin;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = adminPanelBtn.Height;
            sidePanel.Top = adminPanelBtn.Top;
            adminPanelControl1.Dock = DockStyle.Fill;
            adminPanelControl1.Visible = true;
            
           

            wardControl1.Visible = false;
            staffPanelControl1.Visible = false;
            doctorPanelControl1.Visible = false;
            changePasswordControl1.Visible = false;


        }

        private void doctorPanelBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = doctorPanelBtn.Height;
            sidePanel.Top = doctorPanelBtn.Top;

            doctorPanelControl1.Dock = DockStyle.Fill;
            doctorPanelControl1.Visible = true;

            adminPanelControl1.Visible = false;
            wardControl1.Visible = false;
            staffPanelControl1.Visible = false;
            changePasswordControl1.Visible = false;

        }

        private void staffPanelBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = staffPanelBtn.Height;
            sidePanel.Top = staffPanelBtn.Top;
            staffPanelControl1.Dock = DockStyle.Fill;
            staffPanelControl1.Visible = true;

            wardControl1.Visible = false;
            adminPanelControl1.Visible = false;
            doctorPanelControl1.Visible = false;
            changePasswordControl1.Visible = false;




        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = messageBtn.Height;
            sidePanel.Top = messageBtn.Top;
            
            changePasswordControl1.Dock = DockStyle.Fill;
            changePasswordControl1.Visible = true;
            changePasswordControl1.Admin1 = admin;
           
            

            wardControl1.Visible = false;
            adminPanelControl1.Visible = false;
            doctorPanelControl1.Visible = false;
            staffPanelControl1.Visible = false;
            


        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = wardPanelBtn.Height;
            sidePanel.Top = wardPanelBtn.Top;
            wardControl1.Dock = DockStyle.Fill;
            wardControl1.Visible = true;

            staffPanelControl1.Visible = false;
            adminPanelControl1.Visible = false;
            changePasswordControl1.Visible = false;

        }

        private void addAdminControl1_Load(object sender, EventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogInForm l1 = new LogInForm();
            l1.Visible = true;
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            
                
        }
    }
}
