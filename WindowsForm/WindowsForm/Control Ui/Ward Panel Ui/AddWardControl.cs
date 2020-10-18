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
    public partial class AddWardControl : UserControl
    {
        public AddWardControl()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Ward ward = new Ward();
            ward.Name = textBox2.Text;
            WardServices wardServices = new WardServices();
            
            bool check= wardServices.AddWard(ward);
            if(check)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Error !");
            }
        }
    }
}
