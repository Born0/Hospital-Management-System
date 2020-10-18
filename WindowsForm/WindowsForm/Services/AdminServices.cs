using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    public class AdminServices
    {
        AdminRepository adminRepository = new AdminRepository();

        public bool AddAdmin(Admin admin)
        {
            return adminRepository.Insert(admin);
        }
        public List<Admin> GetAll()
        {
            return adminRepository.GetAll();
        }
        public Admin Get(Admin admin)
        {
            return adminRepository.Get(admin);
        }
        public bool Delete(Admin admin)
        {
            return adminRepository.Delete(admin);
        }
        public bool Update(Admin admin)
        {
            return adminRepository.Update(admin);
        }
        public bool UpdatePass(Admin admin)
        {
            return adminRepository.UpdatePass(admin);
        }
    }
}
