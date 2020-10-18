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
    public partial class NotificationControl : UserControl
    {
        public Doctor doctor;

        public NotificationControl(Doctor doctor)
        {
            InitializeComponent();


            this.doctor = new Doctor();
            this.doctor = doctor;


            //Notification
            DoctorService doctorService = new DoctorService();
            Doctor temp = new Doctor();
            temp = doctorService.GetNotification(doctor);
            if (temp != null)
            {
                if (temp.NotificationCount > 0)
                {
                    textBox2.Text = temp.Notfication;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctor temp = new Doctor();
            temp.Phone = this.doctor.Phone;
            temp.NotificationCount = 0;
            temp.Notfication = "";
            DoctorService doctorService = new DoctorService();
            bool check = doctorService.SetNotification(temp);
            if (check)
            {
                MessageBox.Show("Clear");
            }
            else
                MessageBox.Show("Error");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
