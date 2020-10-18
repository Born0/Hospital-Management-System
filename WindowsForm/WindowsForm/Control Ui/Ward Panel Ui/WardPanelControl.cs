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

namespace WindowsForm.Control_Ui
{
    public partial class WardControl : UserControl
    {
        public WardControl()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            wardRoomAdd1.Visible = true;
            wardRoomAdd1.Dock = DockStyle.Fill;

            addWardControl1.Visible = false;
            wardListGridView.Visible = false;
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            //wardListGridView.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WardServices wardServices = new WardServices(); 
            wardListGridView.Visible = true;
            wardRoomAdd1.Visible = false;
            addWardControl1.Visible = false;

            wardListGridView.DataSource = wardServices.GetAll();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            addWardControl1.Dock = DockStyle.Fill;
            addWardControl1.Visible = true;

            
            wardListGridView.Visible = false;
            wardRoomAdd1.Visible = false;

        }

       // private void wardRoomAdd1_Load(object sender, EventArgs e)
        //{

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            Ward temp = new Ward();
            try
            {
                temp.Id = Convert.ToInt32(textBox1.Text);



                WardServices wardServices = new WardServices();
                Ward ward = new Ward();
                ward = wardServices.Get(temp);
                if (ward != null)
                {
                    textBox2.Text = ward.Name;
                    roomListBtn.Show();
                }
                else
                {
                    MessageBox.Show("No Room Found");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Invalid Format");
            }
        }

        private void roomListBtn_Click(object sender, EventArgs e)
        {
            Ward temp = new Ward();
            temp.Id = Convert.ToInt32(textBox1.Text);
            dataGridView1.Show();

            RoomServices roomServices = new RoomServices();
            if (roomServices.GetAllWId(temp) == null)
            {
                MessageBox.Show("NULL");
            }
            else
            {
                dataGridView1.DataSource = roomServices.GetAllWId(temp);
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }
    }
}
