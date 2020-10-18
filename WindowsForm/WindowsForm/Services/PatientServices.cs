using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    public class PatientServices
    {
        PatientRepository patientRepository = new PatientRepository();

        public bool Add(Patient patient)
        {
            return patientRepository.Insert(patient);
        }
        public List<Patient> GetAll()
        {
            return patientRepository.GetAll();
        }

        public List<Patient> GetAllCurrent()
        {
            List<Patient> patients = new List<Patient>();
            patients= patientRepository.GetAll();
            if (patients != null)
            {
                foreach (Patient item in patients.ToList())
                {
                    if (item.Status != 1)
                    {
                        patients.Remove(item);
                    }
                }
                return patients;
            }
            else
                return null;
        }

        public List<Patient> GetAllPrevious()
        {
            List<Patient> patients = new List<Patient>();
            patients = patientRepository.GetAll();
            if (patients != null)
            {
                foreach (Patient item in patients.ToList())
                {
                    if (item.Status == 1)
                    {
                        patients.Remove(item);
                    }
                }
                return patients;
            }
            else
                return null;
        }

        public Patient Get(Patient patient)
        {
            return patientRepository.Get(patient);
        }
        public bool Delete(Patient patient)
        {
            return patientRepository.Delete(patient);
        }
        public bool Update(Patient patient)
        {
            return patientRepository.Update(patient);
        }

        public bool ExtraServicesUpdate(Patient patient)
        {
            return patientRepository.ExtraServicesUpdate(patient);
        }

        public bool PrescriptionUpdate(Patient patient)
        {
            return patientRepository.PrescriptionUpdate(patient);
        }
        public bool ConditionUpdate(Patient patient)
        {
            return patientRepository.ConditionUpdate(patient);
        }
    }
}
