namespace WindowsForm.Control_Ui
{
    partial class WardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wardListGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.editRoomBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.roomListBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addWardControl1 = new WindowsForm.Control_Ui.AddWardControl();
            this.wardRoomAdd1 = new WindowsForm.Control_Ui.AddRoomControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wardListGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Search :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = " Ward Id";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addWardControl1);
            this.panel1.Controls.Add(this.wardListGridView);
            this.panel1.Controls.Add(this.wardRoomAdd1);
            this.panel1.Location = new System.Drawing.Point(306, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 313);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // wardListGridView
            // 
            this.wardListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wardListGridView.Location = new System.Drawing.Point(0, 20);
            this.wardListGridView.Name = "wardListGridView";
            this.wardListGridView.Size = new System.Drawing.Size(315, 190);
            this.wardListGridView.TabIndex = 21;
            this.wardListGridView.Visible = false;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(347, 56);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 25);
            this.button4.TabIndex = 20;
            this.button4.Text = "Load Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // editRoomBtn
            // 
            this.editRoomBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoomBtn.Location = new System.Drawing.Point(124, 359);
            this.editRoomBtn.Name = "editRoomBtn";
            this.editRoomBtn.Size = new System.Drawing.Size(106, 25);
            this.editRoomBtn.TabIndex = 18;
            this.editRoomBtn.Text = "Edit Rooms";
            this.editRoomBtn.UseVisualStyleBackColor = true;
            this.editRoomBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 103);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(97, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ward Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(253, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ward Panel";
            // 
            // button2
            // 
            this.button2.Image = global::WindowsForm.Properties.Resources.icons8_google_web_search_32;
            this.button2.Location = new System.Drawing.Point(217, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 21);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 25);
            this.button3.TabIndex = 19;
            this.button3.Text = "Add New Ward";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // roomListBtn
            // 
            this.roomListBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomListBtn.Location = new System.Drawing.Point(12, 135);
            this.roomListBtn.Name = "roomListBtn";
            this.roomListBtn.Size = new System.Drawing.Size(106, 25);
            this.roomListBtn.TabIndex = 21;
            this.roomListBtn.Text = "Room List";
            this.roomListBtn.UseVisualStyleBackColor = true;
            this.roomListBtn.Visible = false;
            this.roomListBtn.Click += new System.EventHandler(this.roomListBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(288, 165);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.Visible = false;
            // 
            // addWardControl1
            // 
            this.addWardControl1.Location = new System.Drawing.Point(16, 216);
            this.addWardControl1.Name = "addWardControl1";
            this.addWardControl1.Size = new System.Drawing.Size(109, 85);
            this.addWardControl1.TabIndex = 22;
            this.addWardControl1.Visible = false;
            // 
            // wardRoomAdd1
            // 
            this.wardRoomAdd1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wardRoomAdd1.Location = new System.Drawing.Point(152, 216);
            this.wardRoomAdd1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wardRoomAdd1.Name = "wardRoomAdd1";
            this.wardRoomAdd1.Size = new System.Drawing.Size(107, 85);
            this.wardRoomAdd1.TabIndex = 19;
            this.wardRoomAdd1.Visible = false;
            // 
            // WardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roomListBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.editRoomBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Name = "WardControl";
            this.Size = new System.Drawing.Size(643, 407);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wardListGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button editRoomBtn;
        private AddRoomControl wardRoomAdd1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView wardListGridView;
        private AddWardControl addWardControl1;
        private System.Windows.Forms.Button roomListBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
