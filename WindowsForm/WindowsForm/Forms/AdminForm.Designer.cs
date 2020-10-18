namespace WindowsForm.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wardPanelBtn = new System.Windows.Forms.Button();
            this.staffPanelBtn = new System.Windows.Forms.Button();
            this.doctorPanelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.messageBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.adminPanelControl1 = new WindowsForm.Control_Ui.Admin_Panel_Ui.AdminPanelControl();
            this.doctorPanelControl1 = new WindowsForm.Control_Ui.Doctor_Panel_Ui.DoctorPanelControl();
            this.staffPanelControl1 = new WindowsForm.Control_Ui.StaffPanelControl();
            this.wardControl1 = new WindowsForm.Control_Ui.WardControl();
            this.changePasswordControl1 = new WindowsForm.Control_Ui.ChangePasswordControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.wardPanelBtn);
            this.panel1.Controls.Add(this.staffPanelBtn);
            this.panel1.Controls.Add(this.doctorPanelBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.messageBtn);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.adminPanelBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 470);
            this.panel1.TabIndex = 2;
            // 
            // wardPanelBtn
            // 
            this.wardPanelBtn.FlatAppearance.BorderSize = 0;
            this.wardPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wardPanelBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wardPanelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.wardPanelBtn.Image = global::WindowsForm.Properties.Resources.icons8_physical_therapy_32;
            this.wardPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wardPanelBtn.Location = new System.Drawing.Point(9, 288);
            this.wardPanelBtn.Name = "wardPanelBtn";
            this.wardPanelBtn.Size = new System.Drawing.Size(172, 60);
            this.wardPanelBtn.TabIndex = 13;
            this.wardPanelBtn.Text = " Ward Panel";
            this.wardPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wardPanelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.wardPanelBtn.UseVisualStyleBackColor = true;
            this.wardPanelBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // staffPanelBtn
            // 
            this.staffPanelBtn.FlatAppearance.BorderSize = 0;
            this.staffPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffPanelBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffPanelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.staffPanelBtn.Image = global::WindowsForm.Properties.Resources.icons8_commercial_development_management_32;
            this.staffPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffPanelBtn.Location = new System.Drawing.Point(9, 222);
            this.staffPanelBtn.Name = "staffPanelBtn";
            this.staffPanelBtn.Size = new System.Drawing.Size(172, 60);
            this.staffPanelBtn.TabIndex = 12;
            this.staffPanelBtn.Text = "  Staff Panel";
            this.staffPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staffPanelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.staffPanelBtn.UseVisualStyleBackColor = true;
            this.staffPanelBtn.Click += new System.EventHandler(this.staffPanelBtn_Click);
            // 
            // doctorPanelBtn
            // 
            this.doctorPanelBtn.FlatAppearance.BorderSize = 0;
            this.doctorPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doctorPanelBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorPanelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.doctorPanelBtn.Image = global::WindowsForm.Properties.Resources.icons8_doctors_bag_32;
            this.doctorPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorPanelBtn.Location = new System.Drawing.Point(12, 156);
            this.doctorPanelBtn.Name = "doctorPanelBtn";
            this.doctorPanelBtn.Size = new System.Drawing.Size(172, 60);
            this.doctorPanelBtn.TabIndex = 11;
            this.doctorPanelBtn.Text = "  Doctor Panel";
            this.doctorPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doctorPanelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.doctorPanelBtn.UseVisualStyleBackColor = true;
            this.doctorPanelBtn.Click += new System.EventHandler(this.doctorPanelBtn_Click);
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
            this.messageBtn.Image = global::WindowsForm.Properties.Resources.icons8_settings_32;
            this.messageBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.messageBtn.Location = new System.Drawing.Point(12, 354);
            this.messageBtn.Name = "messageBtn";
            this.messageBtn.Size = new System.Drawing.Size(172, 60);
            this.messageBtn.TabIndex = 9;
            this.messageBtn.Text = "  Change \r\n  Password";
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
            // adminPanelBtn
            // 
            this.adminPanelBtn.FlatAppearance.BorderSize = 0;
            this.adminPanelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminPanelBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelBtn.ForeColor = System.Drawing.Color.Transparent;
            this.adminPanelBtn.Image = global::WindowsForm.Properties.Resources.icons8_edit_user_male_32;
            this.adminPanelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminPanelBtn.Location = new System.Drawing.Point(12, 90);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Size = new System.Drawing.Size(172, 60);
            this.adminPanelBtn.TabIndex = 5;
            this.adminPanelBtn.Text = "  Admin Panel";
            this.adminPanelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminPanelBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminPanelBtn.UseVisualStyleBackColor = true;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
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
            this.panel2.TabIndex = 3;
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
            // adminPanelControl1
            // 
            this.adminPanelControl1.Location = new System.Drawing.Point(597, 112);
            this.adminPanelControl1.Name = "adminPanelControl1";
            this.adminPanelControl1.Size = new System.Drawing.Size(165, 137);
            this.adminPanelControl1.TabIndex = 8;
            this.adminPanelControl1.Visible = false;
            // 
            // doctorPanelControl1
            // 
            this.doctorPanelControl1.Location = new System.Drawing.Point(265, 305);
            this.doctorPanelControl1.Name = "doctorPanelControl1";
            this.doctorPanelControl1.Size = new System.Drawing.Size(217, 120);
            this.doctorPanelControl1.TabIndex = 7;
            this.doctorPanelControl1.Visible = false;
            // 
            // staffPanelControl1
            // 
            this.staffPanelControl1.Location = new System.Drawing.Point(568, 255);
            this.staffPanelControl1.Name = "staffPanelControl1";
            this.staffPanelControl1.Size = new System.Drawing.Size(273, 200);
            this.staffPanelControl1.TabIndex = 5;
            this.staffPanelControl1.Visible = false;
            // 
            // wardControl1
            // 
            this.wardControl1.Location = new System.Drawing.Point(288, 59);
            this.wardControl1.Name = "wardControl1";
            this.wardControl1.Size = new System.Drawing.Size(208, 176);
            this.wardControl1.TabIndex = 4;
            this.wardControl1.Visible = false;
            // 
            // changePasswordControl1
            // 
            this.changePasswordControl1.Location = new System.Drawing.Point(536, 74);
            this.changePasswordControl1.Name = "changePasswordControl1";
            this.changePasswordControl1.Size = new System.Drawing.Size(129, 42);
            this.changePasswordControl1.TabIndex = 9;
            this.changePasswordControl1.Visible = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.changePasswordControl1);
            this.Controls.Add(this.adminPanelControl1);
            this.Controls.Add(this.doctorPanelControl1);
            this.Controls.Add(this.staffPanelControl1);
            this.Controls.Add(this.wardControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminForm_Load);
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
        private System.Windows.Forms.Button adminPanelBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button staffPanelBtn;
        private System.Windows.Forms.Button doctorPanelBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button wardPanelBtn;
        private Control_Ui.WardControl wardControl1;
        private Control_Ui.StaffPanelControl staffPanelControl1;
        private Control_Ui.Doctor_Panel_Ui.DoctorPanelControl doctorPanelControl1;
        private Control_Ui.Admin_Panel_Ui.AdminPanelControl adminPanelControl1;
        private Control_Ui.ChangePasswordControl changePasswordControl1;
    }
}