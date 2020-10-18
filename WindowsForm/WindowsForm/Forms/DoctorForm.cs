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
using WindowsForm.Services;

namespace WindowsForm.Forms
{
    public partial class DoctorForm : Form
    {
        private Control_Ui.Doctor_Panel_Ui.NotificationControl notificationControl1;
        private Control_Ui.Doctor_Panel_Ui.PatientInfoForDoctorControl patientInfoForDoctorControl1;
        private Control_Ui.PrescriptionControl prescriptionControl1;
        public Doctor doctor;
        public DoctorForm( Doctor doctor)
        {
            InitializeComponent();           
            this.doctor = new Doctor();
            this.doctor = doctor;
           
            //patient Info for Doctor
            this.patientInfoForDoctorControl1 = new WindowsForm.Control_Ui.Doctor_Panel_Ui.PatientInfoForDoctorControl(this.doctor);
            this.patientInfoForDoctorControl1.Location = new System.Drawing.Point(220, 69);
            this.patientInfoForDoctorControl1.Name = "patientInfoForDoctorControl1";
            this.patientInfoForDoctorControl1.Size = new System.Drawing.Size(870, 470);
            this.patientInfoForDoctorControl1.TabIndex = 5;
            this.patientInfoForDoctorControl1.Visible = false;
            this.Controls.Add(this.patientInfoForDoctorControl1);
            //Prescription
            this.prescriptionControl1 = new WindowsForm.Control_Ui.PrescriptionControl(this.doctor);
            this.prescriptionControl1.Location = new System.Drawing.Point(220,69);
            this.prescriptionControl1.Name = "prescriptionControl1";
            this.prescriptionControl1.Size = new System.Drawing.Size(870, 470);
            this.prescriptionControl1.TabIndex = 4;
            this.prescriptionControl1.Visible = false;
            this.Controls.Add(this.prescriptionControl1);
            //Notifiation Count show

            DoctorService doctorService = new DoctorService();
            Doctor temp = new Doctor();
            temp = doctorService.GetNotification(this.doctor);
            if (temp != null)
            {
                if (temp.NotificationCount > 0)
                {
                    label2.BackColor = Color.Red;
                    label2.Text = temp.NotificationCount.ToString();
                }
            }

            // Notification
            
            this.notificationControl1 = new WindowsForm.Control_Ui.Doctor_Panel_Ui.NotificationControl(doctor);
            this.notificationControl1.Location = new System.Drawing.Point(220, 69);
            this.notificationControl1.Name = "notificationControl1";
            this.notificationControl1.Size = new System.Drawing.Size(870, 470);
            this.notificationControl1.TabIndex = 5;
            this.notificationControl1.Visible = false;
            this.Controls.Add(this.notificationControl1);
        }
       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
        }

        private void patientInfoBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = patientInfoBtn.Height;
            sidePanel.Top = patientInfoBtn.Top;

         
            patientInfoForDoctorControl1.Visible = true;
            prescriptionControl1.Visible = false;
            notificationControl1.Visible = false;
            changePasswordControl1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = prescriptionBtn.Height;
            sidePanel.Top = prescriptionBtn.Top;

           
            prescriptionControl1.Visible = true;
            patientInfoForDoctorControl1.Visible = false;
            notificationControl1.Visible = false;
            changePasswordControl1.Visible = false;
        }

        private void messageBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = messageBtn.Height;
            sidePanel.Top = messageBtn.Top;

            notificationControl1.Visible = true;
            patientInfoForDoctorControl1.Visible = false;
            prescriptionControl1.Visible = false;
            changePasswordControl1.Visible = false;

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LogInForm l1 = new LogInForm();
            l1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;

            changePasswordControl1.Dock = DockStyle.Fill;
            changePasswordControl1.Visible = true;

            changePasswordControl1.Doctor1 = doctor;

            notificationControl1.Visible = false;
            patientInfoForDoctorControl1.Visible = false;
            prescriptionControl1.Visible = false;


        }
    }
}
