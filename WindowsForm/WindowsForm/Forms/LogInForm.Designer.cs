namespace WindowsForm
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.logInBtn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logInBtn.FlatAppearance.BorderSize = 0;
            this.logInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.Location = new System.Drawing.Point(74, 285);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(181, 28);
            this.logInBtn.TabIndex = 2;
            this.logInBtn.Text = "Log In";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.White;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.regBtn.Location = new System.Drawing.Point(74, 329);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(181, 29);
            this.regBtn.TabIndex = 3;
            this.regBtn.Text = "Forget Password";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(74, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 18);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Username";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(76, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 18);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Location = new System.Drawing.Point(74, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(74, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 1);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsForm.Properties.Resources.icons8_lock_32;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(35, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // UserBox
            // 
            this.UserBox.BackColor = System.Drawing.Color.White;
            this.UserBox.BackgroundImage = global::WindowsForm.Properties.Resources.icons8_user_32;
            this.UserBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("UserBox.ErrorImage")));
            this.UserBox.Location = new System.Drawing.Point(35, 169);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(24, 24);
            this.UserBox.TabIndex = 4;
            this.UserBox.TabStop = false;
            this.UserBox.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsForm.Properties.Resources.icons8_delete_sign_322;
            this.button1.Location = new System.Drawing.Point(314, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 18);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(341, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.logInBtn);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Movable = false;
            this.Name = "LogInForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.PictureBox UserBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}

