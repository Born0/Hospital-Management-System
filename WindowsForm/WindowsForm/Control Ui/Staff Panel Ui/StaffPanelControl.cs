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

namespace WindowsForm.Control_Ui
{
    public partial class StaffPanelControl : UserControl
    {
        public StaffPanelControl()
        {
            InitializeComponent();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            addStaffControl1.Dock = DockStyle.Fill;
            addStaffControl1.Visible = true;
            staffListGridView.Visible = false;

        }

      

        private void loadBtn_Click(object sender, EventArgs e)
        {
            staffListGridView.Visible = true;

            addStaffControl1.Visible = false;

            StaffServices staffServices = new StaffServices();
            staffListGridView.DataSource =staffServices.GetAll();



        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
           StaffServices staffServices = new  StaffServices();
            Staff temp = new Staff();
            temp.Phone = textBox1.Text;
            Staff staff = new Staff();
            staff = staffServices.Get(temp);
            if (staff == null)
            {
                MessageBox.Show("Not Found !");
            }
            else
            {
                textBox2.Text = staff.Name;
                textBox4.Text = staff.Gender;
                textBox3.Text = staff.Address;
                textBox7.Text = staff.Phone;
                textBox5.Text = staff.Salary.ToString();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            StaffServices staffServices = new StaffServices();
            Staff temp = new Staff();
            temp.Phone = textBox1.Text;
            bool check = staffServices.Delete(temp);
            if (check)
            {
                MessageBox.Show("Staff Deleted");
            }
            else
            {
                MessageBox.Show("Error Occured !");
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            StaffServices staffServices = new StaffServices();
            Staff staff = new Staff();
            staff.Name = textBox2.Text;
            staff.Gender = textBox4.Text;
            staff.Address = textBox3.Text;
            staff.Phone = textBox7.Text;
            staff.Salary = Convert.ToDouble(textBox5.Text);
            bool check = staffServices.Update(staff);
            if (check)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error Occured !");
            }
        }
    }
}
