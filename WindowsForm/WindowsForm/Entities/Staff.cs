using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Entities
{
    public class Staff:Person
    {
        public string Dob { get; set; }
        public double Salary { get; set; }
        public string Password { get; set; }
    }
}
