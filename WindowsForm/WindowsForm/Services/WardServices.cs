using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    public class WardServices
    {
        WardRepository wardRepository = new WardRepository();

        public bool AddWard(Ward ward)
        {
            return wardRepository.Insert(ward);
        }
        public List<Ward> GetAll()
        {
            return wardRepository.GetAll();
        }
        public Ward Get(Ward ward)
        {
            return wardRepository.Get(ward);
        }
    }
}
