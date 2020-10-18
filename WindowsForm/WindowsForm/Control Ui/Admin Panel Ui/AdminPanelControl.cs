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

namespace WindowsForm.Control_Ui.Admin_Panel_Ui
{
    public partial class AdminPanelControl : UserControl
    {

        public AdminPanelControl()
        {
            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            addAdminControl1.Dock = DockStyle.Fill;
            addAdminControl1.Visible = true;
            adminListGridView.Visible = false;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            AdminServices adminServices = new AdminServices();

            addAdminControl1.Visible = false;
            adminListGridView.Visible = true;
            adminListGridView.DataSource = adminServices.GetAll();

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            AdminServices adminServices = new AdminServices();
            Admin temp = new Admin();
            temp.Phone = textBox1.Text;
            Admin admin = new Admin();
            admin = adminServices.Get(temp);
            if (admin == null)
            {
                MessageBox.Show("Not Found !");
            }
            else
            {
                textBox2.Text = admin.Name;
                textBox4.Text = admin.Gender;
                textBox3.Text = admin.Address;
                textBox7.Text = admin.Phone;
                textBox5.Text = admin.Salary.ToString();
            }

        }

       
        

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {
            AdminServices adminServices = new AdminServices();
            Admin admin = new Admin();
            admin.Name = textBox2.Text;
            admin.Gender = textBox4.Text;
            admin.Address = textBox3.Text;
            admin.Phone = textBox7.Text;
            admin.Salary = Convert.ToDouble(textBox5.Text);
            bool check = adminServices.Update(admin);
            if (check)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error Occured !");
            }
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            AdminServices adminServices = new AdminServices();
            Admin temp = new Admin();
            temp.Phone = textBox1.Text;
            bool check = adminServices.Delete(temp);
            if (check)
            {
                MessageBox.Show("Admin Deleted");
            }
            else
            {
                MessageBox.Show("Error Occured !");
            }
        }
    }
}
