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

namespace WindowsForm
{
    public partial class PatientRegistrationControl : UserControl
    {
        public int patientId ;
        
        public PatientRegistrationControl()
        {
            InitializeComponent();
            
        }

      

        private void button1_Click(object sender, EventArgs e)
        {




            if (textBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox5.Text == "" ||
               textBox8.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" ||
               comboBox4.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Provide all information...");

            }

            else
            {

                Patient patient = new Patient();

                patient.Name = textBox2.Text;
                patient.Gender = comboBox1.Text;
                patient.Address = textBox3.Text;

                patient.Phone = textBox5.Text;
                patient.Date = dateTimePicker1.Text.ToString();
                patient.Age = Convert.ToInt32(textBox4.Text);
                patient.Emergency = textBox8.Text;
                patient.PatientType = comboBox2.Text;
                patient.RoomNumber = Convert.ToInt32(comboBox5.Text);
                patient.Seat = Convert.ToInt32(textBox6.Text);
                patient.Consultant = comboBox4.Text;
                patient.TotalCost = Convert.ToDouble(textBox7.Text);
                patient.Status = 1;
                patient.ReadyToRelease = "NO";
                patient.ReleaseCondition = null;
                patient.OT = 0;

                PatientServices patientServices = new PatientServices();
                bool check = patientServices.Add(patient);
                if (check)
                {
                    List<Patient> patients = new List<Patient>();
                    patients = patientServices.GetAll();
                    foreach (var item in patients)
                    {
                        if (item.Phone == textBox5.Text)
                        {
                            patientId = item.Id;
                            break;
                        }
                    }
                    MessageBox.Show("Patient Id : " + patientId.ToString());

                    Room room = new Room();
                    room.RoomNumber = Convert.ToInt32(comboBox5.Text);
                    room.Status = Convert.ToInt32(textBox6.Text);
                    RoomServices roomServices = new RoomServices();
                    roomServices.UpdateStatus(room);

                    textBox2.Text = String.Empty;
                    //textBox9.Text = String.Empty;
                    textBox4.Text = String.Empty;
                    textBox3.Text = String.Empty;
                    textBox5.Text = String.Empty;
                    textBox8.Text = String.Empty;
                    textBox6.Text = String.Empty;
                    textBox7.Text = String.Empty;
                    comboBox1.Text = String.Empty;
                    comboBox2.Text = String.Empty;
                    comboBox3.Text = String.Empty;
                    comboBox4.Text = String.Empty;
                    //comboBox5.Text = String.Empty;

                }
                else
                {
                    MessageBox.Show("Error Occured !");

                }
                //notify doctor
                DoctorService doctorService = new DoctorService();
                Doctor temp = new Doctor();

                List<Doctor> doctors = new List<Doctor>();
                doctors = doctorService.GetAll();
                foreach (Doctor item in doctors)
                {
                    if ((item.Name + ":" + item.Phone).Equals(patient.Consultant))
                    {
                        temp = item;
                        break;
                    }
                }
                //Doctor doctor = new Doctor();
                //doctor = doctorService.Get(temp);


                temp.NotificationCount += 1;
                temp.Notfication += "\n New Patient Added Id is:" + patientId.ToString();
                bool check2 = doctorService.SetNotification(temp);
                if (check2)
                {
                    MessageBox.Show("notified");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
           

        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
            List<Ward> wards = new List<Ward>();
            WardServices wardServices = new WardServices();
            wards = wardServices.GetAll();
            List<string> wNames = new List<string>();
            foreach (Ward item in wards)
            {
                wNames.Add(item.Name);
            }
            comboBox2.DataSource = wNames;



        }

        private void comboBox5_Click(object sender, EventArgs e)
        {
           // comboBox5.Text = String.Empty;

            List<Ward> wards = new List<Ward>();
            WardServices wardServices = new WardServices();
            wards = wardServices.GetAll();
            List<string> wNames = new List<string>();


            string currentWardName = comboBox2.Text;
            
            Ward temp = new Ward();
            foreach (Ward item in wards)
            {
                if (item.Name == currentWardName)
                {
                    temp = item;
                    break;
                }
            }
            List<Room> rooms = new List<Room>();

            RoomServices roomServices = new RoomServices();
            rooms = roomServices.GetAllWId(temp);

            string roomtype = comboBox3.Text;

            foreach (Room item in rooms.ToList())
            {
                if (item.Status > 1)
                {
                    rooms.Remove(item);
                }
                if(item.Type!=roomtype)
                {
                    rooms.Remove(item);
                }
            }
            List<int> rId = new List<int>();
            foreach (Room item in rooms)
            {
                rId.Add(item.RoomNumber);
            }
            comboBox5.DataSource = rId;
        }

        private void comboBox5_TextChanged(object sender, EventArgs e)
        {
           
            int temp = 0;
             int roomNumber = Convert.ToInt32(comboBox5.Text);
          
            List<Room> rooms = new List<Room>();
            RoomServices roomServices = new RoomServices();
            rooms = roomServices.GetAll();
          
            foreach (Room item in rooms)
            {
                if (item.RoomNumber == roomNumber)
                {
                    temp = item.Status;
                    break;
                }         

            }

            if (temp == 0)
            {
                textBox6.Text = 1.ToString();
            }
            else
            {
                textBox6.Text = 2.ToString();
            }

           

            int roomNumber1 = Convert.ToInt32(comboBox5.Text);
            double price = 0;
            List<Room> rooms1 = new List<Room>();
            RoomServices roomServices1 = new RoomServices();
            rooms1 = roomServices1.GetAll();
            foreach (Room item in rooms1)
            {
                if (item.RoomNumber == roomNumber1)
                {
                    price = item.Price;
                    break;
                }
            }
            textBox7.Text = price.ToString();
         
        }

        private void comboBox4_Click(object sender, EventArgs e)
        {

            List<Ward> wards = new List<Ward>();
            WardServices wardServices = new WardServices();
            wards = wardServices.GetAll();
            List<string> wNames = new List<string>();


            string currentWardName = comboBox2.Text;

            Ward temp = new Ward();
            foreach (Ward item in wards)
            {
                if (item.Name == currentWardName)
                {
                    temp = item;
                    break;
                }
            }

            List<Doctor> doctors = new List<Doctor>();
            DoctorService doctorService = new DoctorService();
            doctors= doctorService.GetAll();
            foreach (Doctor item in doctors.ToList())
            {
                if(temp.Id!=item.WId)
                {
                    doctors.Remove(item);
                }
            }

            List<string> dName = new List<string>();
            foreach (Doctor item in doctors)
            {
                dName.Add(item.Name +":"+item.Phone);
            }
            comboBox4.DataSource = dName;



        }

        private void comboBox3_Click(object sender, EventArgs e)
        {
           // comboBox5.Text = " ";
            textBox6.Text = "  ";
            textBox7.Text = "  ";


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if(System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text,"[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter only Numbers");
                textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox4.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter Valid age");
                textBox4.Text = textBox4.Text.Remove(textBox4.Text.Length - 1);
            }
        }
    }
}
