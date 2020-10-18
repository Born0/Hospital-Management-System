namespace WindowsForm
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.messageBtn = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.checkOutHisBtn = new System.Windows.Forms.Button();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.patientInfoBtn = new System.Windows.Forms.Button();
            this.patientRegBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.checkOutHistoryControl1 = new WindowsForm.Control_Ui.CheckOutHistoryControl();
            this.checkOutControl1 = new WindowsForm.Control_Ui.CheckOutControl();
            this.patientInfoControl1 = new WindowsForm.PatientInfoControl();
            this.patientRegistrationControl1 = new WindowsForm.PatientRegistrationControl();
            this.changePasswordControl1 = new WindowsForm.Control_Ui.ChangePasswordControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logOutBtn);
            this.panel1.Controls.Add(this.messageBtn);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.checkOutHisBtn);
            this.panel1.Controls.Add(this.checkOutBtn);
            this.panel1.Controls.Add(this.patientInfoBtn);
            this.panel1.Controls.Add(this.patientRegBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 470);
            this.panel1.TabIndex = 0;
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
            this.messageBtn.Location = new System.Drawing.Point(12, 357);
            this.messageBtn.Name = "messageBtn";
            this.messageBtn.Size = new System.Drawing.Size(172, 60);
            this.messageBtn.TabIndex = 9;
            this.messageBtn.Text = " Change\r\n  Password\r\n";
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
            // checkOutHisBtn
            // 
            this.checkOutHisBtn.FlatAppearance.BorderSize = 0;
            this.checkOutHisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutHisBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutHisBtn.ForeColor = System.Drawing.Color.Transparent;
            this.checkOutHisBtn.Image = global::WindowsForm.Properties.Resources.clock_26px;
            this.checkOutHisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutHisBtn.Location = new System.Drawing.Point(12, 291);
            this.checkOutHisBtn.Name = "checkOutHisBtn";
            this.checkOutHisBtn.Size = new System.Drawing.Size(195, 60);
            this.checkOutHisBtn.TabIndex = 8;
            this.checkOutHisBtn.Text = "   Check Out History";
            this.checkOutHisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutHisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutHisBtn.UseVisualStyleBackColor = true;
            this.checkOutHisBtn.Click += new System.EventHandler(this.checkOutHisBtn_Click_1);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.FlatAppearance.BorderSize = 0;
            this.checkOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkOutBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.checkOutBtn.Image = global::WindowsForm.Properties.Resources.checked_user_26px;
            this.checkOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.Location = new System.Drawing.Point(12, 225);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(195, 60);
            this.checkOutBtn.TabIndex = 7;
            this.checkOutBtn.Text = "   Check Out";
            this.checkOutBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkOutBtn.UseVisualStyleBackColor = true;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // patientInfoBtn
            // 
            this.patientInfoBtn.FlatAppearance.BorderSize = 0;
            this.patientInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientInfoBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInfoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.patientInfoBtn.Image = global::WindowsForm.Properties.Resources.hotel_information_26px;
            this.patientInfoBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientInfoBtn.Location = new System.Drawing.Point(12, 159);
            this.patientInfoBtn.Name = "patientInfoBtn";
            this.patientInfoBtn.Size = new System.Drawing.Size(195, 60);
            this.patientInfoBtn.TabIndex = 5;
            this.patientInfoBtn.Text = "   Patient Info";
            this.patientInfoBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientInfoBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientInfoBtn.UseVisualStyleBackColor = true;
            this.patientInfoBtn.Click += new System.EventHandler(this.patientInfoBtn_Click);
            // 
            // patientRegBtn
            // 
            this.patientRegBtn.FlatAppearance.BorderSize = 0;
            this.patientRegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientRegBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRegBtn.ForeColor = System.Drawing.Color.Transparent;
            this.patientRegBtn.Image = global::WindowsForm.Properties.Resources.cast_26px;
            this.patientRegBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientRegBtn.Location = new System.Drawing.Point(12, 93);
            this.patientRegBtn.Name = "patientRegBtn";
            this.patientRegBtn.Size = new System.Drawing.Size(195, 60);
            this.patientRegBtn.TabIndex = 4;
            this.patientRegBtn.Text = "  Patient Registration";
            this.patientRegBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientRegBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.patientRegBtn.UseVisualStyleBackColor = true;
            this.patientRegBtn.Click += new System.EventHandler(this.patientRegBtn_Click);
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
            this.panel2.TabIndex = 1;
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
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
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
            // checkOutHistoryControl1
            // 
            this.checkOutHistoryControl1.Location = new System.Drawing.Point(393, 186);
            this.checkOutHistoryControl1.Name = "checkOutHistoryControl1";
            this.checkOutHistoryControl1.Size = new System.Drawing.Size(129, 86);
            this.checkOutHistoryControl1.TabIndex = 5;
            this.checkOutHistoryControl1.Visible = false;
            // 
            // checkOutControl1
            // 
            this.checkOutControl1.Location = new System.Drawing.Point(213, 186);
            this.checkOutControl1.Name = "checkOutControl1";
            this.checkOutControl1.Size = new System.Drawing.Size(117, 99);
            this.checkOutControl1.TabIndex = 4;
            this.checkOutControl1.Visible = false;
            // 
            // patientInfoControl1
            // 
            this.patientInfoControl1.Location = new System.Drawing.Point(393, 50);
            this.patientInfoControl1.Name = "patientInfoControl1";
            this.patientInfoControl1.Size = new System.Drawing.Size(106, 111);
            this.patientInfoControl1.TabIndex = 3;
            this.patientInfoControl1.Visible = false;
            // 
            // patientRegistrationControl1
            // 
            this.patientRegistrationControl1.Location = new System.Drawing.Point(213, 50);
            this.patientRegistrationControl1.Name = "patientRegistrationControl1";
            this.patientRegistrationControl1.Size = new System.Drawing.Size(117, 103);
            this.patientRegistrationControl1.TabIndex = 2;
            this.patientRegistrationControl1.Visible = false;
            // 
            // changePasswordControl1
            // 
            this.changePasswordControl1.Admin1 = null;
            this.changePasswordControl1.Location = new System.Drawing.Point(537, 289);
            this.changePasswordControl1.Name = "changePasswordControl1";
            this.changePasswordControl1.Size = new System.Drawing.Size(115, 68);
            this.changePasswordControl1.TabIndex = 6;
            this.changePasswordControl1.Visible = false;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 470);
            this.Controls.Add(this.changePasswordControl1);
            this.Controls.Add(this.checkOutHistoryControl1);
            this.Controls.Add(this.checkOutControl1);
            this.Controls.Add(this.patientInfoControl1);
            this.Controls.Add(this.patientRegistrationControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button checkOutHisBtn;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.Button patientInfoBtn;
        private System.Windows.Forms.Button patientRegBtn;
        private PatientRegistrationControl patientRegistrationControl1;
        private PatientInfoControl patientInfoControl1;
        private Control_Ui.CheckOutControl checkOutControl1;
        private Control_Ui.CheckOutHistoryControl checkOutHistoryControl1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button messageBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Label label1;
        private Control_Ui.ChangePasswordControl changePasswordControl1;
    }
}