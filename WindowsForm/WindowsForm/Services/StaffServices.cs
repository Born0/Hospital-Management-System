using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    public class StaffServices
    {
        StaffRepository staffRepository = new StaffRepository();
        public bool Add(Staff staff)
        {
            return staffRepository.Insert(staff);
        }
        public List<Staff> GetAll()
        {
            return staffRepository.GetAll();
        }
        public Staff Get(Staff staff)
        {
            return staffRepository.Get(staff);
        }
        public bool Delete(Staff staff)
        {
            return staffRepository.Delete(staff);
        }
        public bool Update(Staff staff)
        {
            return staffRepository.Update(staff);
        }
        public bool UpdatePass(Staff staff)
        {
            return staffRepository.UpdatePass(staff);
        }
    }
}
