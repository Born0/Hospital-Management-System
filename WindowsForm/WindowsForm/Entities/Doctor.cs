using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Entities
{
    public class Doctor:Person
    {
        public string Dob { get; set; }
        public double Salary { get; set; }
        public string Password { get; set; }
        public int WId { get; set; }
        public int NotificationCount { get; set; }
        public string Notfication { get; set; }
    }
}
