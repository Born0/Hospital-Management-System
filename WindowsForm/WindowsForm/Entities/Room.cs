using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Status { get; set; }
        public int WId { get; set; }
    }
}
