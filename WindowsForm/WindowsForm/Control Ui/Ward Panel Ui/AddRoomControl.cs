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
    public partial class AddRoomControl : UserControl
    {
        public AddRoomControl()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            label7.Text = "Status";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "Status";
            //comboBox1.Hide();
            //comboBox2.Hide();
            //textBox2.Show();
            //textBox3.Show();

            Room temp = new Room();
            RoomServices roomServices = new RoomServices();
            Room room = new Room();
            WardServices wardServices = new WardServices();
            Ward ward = new Ward();
            Ward Wtemp = new Ward();

            temp.RoomNumber = Convert.ToInt32(textBox1.Text);

            room = roomServices.GetByRoomNumber(temp);
            if(room.Type!=null)
            {
 
                Wtemp.Id = room.WId;
               
                ward = wardServices.Get(Wtemp);

                comboBox1.Text = ward.Name;
                textBox5.Text = room.Status.ToString();
                comboBox2.Text = room.Type;
            }
            else
            {
                MessageBox.Show("Not found");
            }

        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            label7.Text = "Room Number";
            comboBox1.Enabled = true;
            textBox5.Enabled = true;
            updateBtn.Hide();
            confirmBtn.Show();

            WardServices wardServices = new WardServices();

            List<Ward> wards = new List<Ward>();
            wards = wardServices.GetAll();
            List<string> names = new List<string>();
            
            foreach(Ward index in wards)
            {
                names.Add(index.Name);
            }
            comboBox1.DataSource = names;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            RoomServices roomServices = new RoomServices();
            label7.Text = "Status";
            updateBtn.Show();
            confirmBtn.Hide();
            Ward ward = new Ward();
            ward.Name = comboBox1.Text;
            int WardId = roomServices.GetWId(ward).Id;

            Room room = new Room();
            room.WId = WardId;
            room.RoomNumber =Convert.ToInt32 (textBox5.Text);
            room.Type = comboBox2.Text;
            

            
            bool check= roomServices.Add(room);
            if(check)
            {
                MessageBox.Show("Added");
            }
            else
            {
                MessageBox.Show("Error !");
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Type = comboBox2.Text;

            RoomServices roomServices = new RoomServices();
            bool check = roomServices.Update(room);
            if(check)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error !");
            }


        }
    }
}
