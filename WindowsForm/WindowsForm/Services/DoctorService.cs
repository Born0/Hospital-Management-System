using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    class DoctorService
    {
        DoctorRepository doctorRepository = new DoctorRepository();

        public bool AddDoctor(Doctor doctor)
        {
            return doctorRepository.Insert(doctor);
        }
        public List<Doctor> GetAll()
        {
            return doctorRepository.GetAll();
        }
        public Doctor Get(Doctor doctor)
        {
            return doctorRepository.Get(doctor);
        }
        public bool Delete(Doctor doctor)
        {
            return doctorRepository.Delete(doctor);
        }
        public bool Update(Doctor doctor)
        {
            return doctorRepository.Update(doctor);
        }
        public bool UpdatePass(Doctor doctor)
        {
            return doctorRepository.UpdatePass(doctor);
        }

        public Doctor GetNotification(Doctor doctor)
        {
            return doctorRepository.GetNotification(doctor);
        }
        public bool SetNotification(Doctor doctor)
        {
            return doctorRepository.SetNotification(doctor);
        }

    }
}
