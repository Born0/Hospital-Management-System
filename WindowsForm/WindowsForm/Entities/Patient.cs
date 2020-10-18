using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Entities
{
    public class Patient:Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Date { get; set; }
        public string CheckOutDate { get; set; }
        public string Emergency { get; set; }
        public string PatientType { get; set; }
        public int RoomNumber { get; set; }
        public int Seat { get; set; }
        public string Consultant { get; set; }
        public double TotalCost { get; set; }
        public string ReadyToRelease { get; set; }
        public string ReleaseCondition { get; set; }
        public int Status { get; set; }
        public int OT { get; set; }
        public string ExtraServices { get; set; }
        public string Prescription { get; set; }
       
    }
}
