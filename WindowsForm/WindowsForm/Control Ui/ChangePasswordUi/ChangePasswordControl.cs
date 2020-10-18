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
    public partial class ChangePasswordControl : UserControl
    {
        

        public ChangePasswordControl()
        {
            InitializeComponent();
        }

        public Admin Admin1
        {
            get;set;
        }
        public Doctor Doctor1
        {
            set;get;
        }
        public Staff Staff1
        {
            set; get;
        }



        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (Admin1 != null )
            {
                if (textBox1.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Plese Insert password first");
                }
                else
                {
                    if (textBox4.Text.Equals(textBox1.Text))
                    {
                        AdminServices adminservice = new AdminServices();
                        Admin1.Password = textBox1.Text;
                        adminservice.UpdatePass(Admin1);
                        MessageBox.Show("Password changed ");
                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                    }

                }
            }
            else if(Staff1!=null)
            {
                if (textBox1.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Plese Insert password first");
                }
                else
                {
                    if (textBox4.Text.Equals(textBox1.Text))
                    {
                        StaffServices staffServices = new StaffServices();
                        Staff1.Password = textBox1.Text;
                        staffServices.UpdatePass(Staff1);
                        MessageBox.Show("Password changed " );
                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                    }

                }
            }
            else if (Doctor1!=null)
            {
                if (textBox1.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("Plese Insert password first");
                }
                else
                {
                    if (textBox4.Text.Equals(textBox1.Text))
                    {
                        DoctorService doctorService = new DoctorService();
                        Doctor1.Password = textBox1.Text;
                        doctorService.UpdatePass(Doctor1);
                        MessageBox.Show("Password changed ");
                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                    }

                }
            }
        }

        private void ChangePasswordControl_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "";
        }
    }
}
