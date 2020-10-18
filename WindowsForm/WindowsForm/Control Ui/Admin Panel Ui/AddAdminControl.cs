﻿using System;
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

namespace WindowsForm.Control_Ui.Admin_Panel_Ui
{
    public partial class AddAdminControl : UserControl
    {
        public AddAdminControl()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox6.Text == "" ||
               textBox8.Text == "" || comboBox1.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Provide all information...");

            }
            else
            {
                Admin admin = new Admin();
                admin.Name = textBox2.Text;

                admin.Gender = comboBox1.Text;
                admin.Phone = textBox1.Text;
                admin.Address = textBox4.Text;
                admin.Dob = textBox7.Text;
                admin.Salary = Convert.ToDouble(textBox6.Text);
                admin.Password = textBox8.Text;

                AdminServices adminServices = new AdminServices();
                bool check = adminServices.AddAdmin(admin);
                if (check)
                {
                    MessageBox.Show("Admin Added");
                }
                else
                {
                    MessageBox.Show("Error Occured !");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }
    }
}
