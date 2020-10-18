namespace WindowsForm.Forms
{
    partial class DoctorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.prescriptionBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.messageBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.patientInfoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.changePasswordControl1 = new WindowsForm.Control_Ui.ChangePasswordControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prescriptionBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.messageBtn);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.patientInfoBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 470);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(118, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // prescriptionBtn
            // 
            this.prescriptionBtn.FlatAppearance.BorderSize = 0;
            this.prescriptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prescriptionBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionBtn.ForeColor = System.Drawing.Color.Transparent;
            this.prescriptionBtn.Image = global::WindowsForm.Properties.Resources.icons8_hand_with_a_pill_32;
            this.prescriptionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prescriptionBtn.Location = new System.Drawing.Point(12, 156);
            this.prescriptionBtn.Name = "prescriptionBtn";
            this.prescriptionBtn.Size = new System.Drawing.Size(172, 60);
            this.prescriptionBtn.TabIndex = 11;
            this.prescriptionBtn.Text = "Prescription";
            this.prescriptionBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.prescriptionBtn.UseVisualStyleBackColor = true;
            this.prescriptionBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Log Out";
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logOutBtn.FlatAppearance.BorderSize = 0;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutBtn.Image = global::WindowsForm.Properties.Resources.icons8_logout_rounded_left_32;
            this.logOutBtn.Location = new System.Drawing.Point(22, 430);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logOutBtn.Size = new System.Drawing.Size(28, 28);
            this.logOutBtn.TabIndex = 10;
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // messageBtn
            // 
            this.messageBtn.FlatAppearance.BorderSize = 0;
            this.messageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.messageBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBtn.ForeColor = System.Drawing.Color.Transparent;
            this.messageBtn.Image = global::WindowsForm.Properties.Resources.icons8_filled_message_32;
            this.messageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageBtn.Location = new System.Drawing.Point(12, 222);
            this.messageBtn.Name = "messageBtn";
            this.messageBtn.Size = new System.Drawing.Size(172, 60);
            this.messageBtn.TabIndex = 9;
            this.messageBtn.Text = "  Notification";
            this.messageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.messageBtn.UseVisualStyleBackColor = true;
            this.messageBtn.Click += new System.EventHandler(this.messageBtn_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.sidePanel.Location = new System.Drawing.Point(1, 89);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 64);
            this.sidePanel.TabIndex = 6;
            // 
            // patientInfoBtn
            // 
            this.patientInfoBtn.FlatAppearance.BorderSize = 0;
            this.patientInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientInfoBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInfoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.patientInfoBtn.Image = global::WindowsForm.Properties.Resources.hotel_information_26px;
            this.patientInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientInfoBtn.Location = new System.Drawing.Point(12, 90);
            this.patientInfoBtn.Name = "patientInfoBtn";
            this.patientInfoBtn.Size = new System.Drawing.Size(172, 60);
            this.patientInfoBtn.TabIndex = 5;
            this.patientInfoBtn.Text = "   Patient Info";
            this.patientInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientInfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientInfoBtn.UseVisualStyleBackColor = true;
            this.patientInfoBtn.Click += new System.EventHandler(this.patientInfoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::WindowsForm.Properties.Resources.icons8_clinic_64;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 87);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(686, 34);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsForm.Properties.Resources.icons8_minus_math_321;
            this.button1.Location = new System.Drawing.Point(600, 3);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Image = global::WindowsForm.Properties.Resources.icons8_delete_sign_323;
            this.exitBtn.Location = new System.Drawing.Point(649, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitBtn.Size = new System.Drawing.Size(24, 24);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = global::WindowsForm.Properties.Resources.icons8_settings_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(9, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "  Change \r\n  Password";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // changePasswordControl1
            // 
            this.changePasswordControl1.Admin1 = null;
            this.changePasswordControl1.Doctor1 = null;
            this.changePasswordControl1.Location = new System.Drawing.Point(365, 159);
            this.changePasswordControl1.Name = "changePasswordControl1";
            this.changePasswordControl1.Size = new System.Drawing.Size(151, 75);
            this.changePasswordControl1.Staff1 = null;
            this.changePasswordControl1.TabIndex = 3;
            this.changePasswordControl1.Visible = false;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.changePasswordControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button messageBtn;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button patientInfoBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button prescriptionBtn;
        //private Control_Ui.PrescriptionControl prescriptionControl1;
        //private Control_Ui.Doctor_Panel_Ui.NotificationControl notificationControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private Control_Ui.ChangePasswordControl changePasswordControl1;
        //private Control_Ui.Doctor_Panel_Ui.PatientInfoForDoctorControl patientInfoForDoctorControl1;
    }
}