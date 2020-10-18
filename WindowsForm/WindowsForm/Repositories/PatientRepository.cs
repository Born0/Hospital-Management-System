using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Interfaces;

namespace WindowsForm.Repositories
{
    public class PatientRepository : IRepository<Patient>, IDisposable
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Patient> GetAll()
        {
            string sql = "Select * From Patients";
            reader = db.GetData(sql);
            List<Patient> allPatients = new List<Patient>();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(reader["Id"]);
                patient.Name = reader["Name"].ToString();
                patient.Gender = reader["Gender"].ToString();
                patient.Phone = reader["Phone"].ToString();
                patient.Address = reader["Address"].ToString();
                patient.Age = Convert.ToInt32(reader["Age"]);
                patient.Date = reader["Date"].ToString();
                patient.Emergency = reader["Emergency"].ToString();
                patient.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                patient.Seat = Convert.ToInt32(reader["Seat"]);
                patient.Consultant = reader["Consultant"].ToString();
                patient.CheckOutDate = reader["CheckOutDate"].ToString();
                patient.TotalCost = Convert.ToDouble(reader["TotalCost"]);
                patient.Status = Convert.ToInt32(reader["Status"]);
                patient.ReadyToRelease = reader["ReadyToRelease"].ToString();
                patient.ReleaseCondition = reader["ReleaseCondition"].ToString();
                patient.PatientType = reader["PatientType"].ToString();
                patient.Prescription = reader["Prescription"].ToString();
                if (!reader["OT"].Equals(null))
                {
                    patient.OT = Convert.ToInt32(reader["OT"]);
                }
                
                
                patient.ExtraServices = reader["ExtraServices"].ToString();


                allPatients.Add(patient);
            }
            return allPatients;
        }
        public Patient Get(Patient entity)
        {
            try
            {
                string sql = " Select * From Patients Where Id='" + entity.Id + "'";
                reader = db.GetData(sql);
                Patient patient = new Patient();
                while (reader.Read())
                {

                    patient.Id = Convert.ToInt32(reader["Id"]);
                    patient.Name = reader["Name"].ToString();
                    patient.Gender = reader["Gender"].ToString();
                    patient.Phone = reader["Phone"].ToString();
                    patient.Address = reader["Address"].ToString();
                    patient.Age = Convert.ToInt32(reader["Age"]);
                    patient.Date = reader["Date"].ToString();
                    patient.Emergency = reader["Emergency"].ToString();
                    patient.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                    patient.Seat = Convert.ToInt32(reader["Seat"]);
                    patient.Consultant = reader["Consultant"].ToString();
                    patient.CheckOutDate = reader["CheckOutDate"].ToString();
                    patient.TotalCost = Convert.ToDouble(reader["TotalCost"]);
                    patient.Status = Convert.ToInt32(reader["Status"]);
                    patient.ReadyToRelease = reader["ReadyToRelease"].ToString();
                    patient.ReleaseCondition = reader["ReleaseCondition"].ToString();

                    if (reader["OT"] == null)
                    {

                    }
                    else
                    {
                        patient.OT = Convert.ToInt32(reader["OT"]);
                    }

                    patient.ExtraServices = reader["ExtraServices"].ToString();
                }
                return patient;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Insert(Patient entity)
        {
            try
            {

                string sql = "Insert Into Patients( Name,Gender,Phone,Address,Age,Date,Emergency,RoomNumber,Seat,Consultant,TotalCost,PatientType,Status,ReadyToRelease,ReleaseCondition,OT)" +
                "  Values('" + entity.Name + "','" + entity.Gender + "','" + entity.Phone + "','" + entity.Address + "','" + entity.Age + "','" + entity.Date + "','" + entity.Emergency + "','" + entity.RoomNumber + "','" + entity.Seat + "','" + entity.Consultant + "','" + entity.TotalCost + "','" + entity.PatientType + "','" + entity.Status + "','" + entity.ReadyToRelease + "','" + entity.ReleaseCondition + "','" + entity.OT + "')";

                int result = db.ExecuteQuery(sql);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception e)
            {
                return false;
            }
        }
        public bool Update(Patient entity)
        {
            try
            {
                db = new DataAccess();
                string sql = " Update Patients Set CheckOutDate='"+entity.CheckOutDate+"',Status='"+entity.Status+"'Where Id='"+entity.Id+"'  ";
                int result = db.ExecuteQuery(sql);

            //entity.Seat = entity.Seat - 1;
            Room room = new Room();
            room.RoomNumber = entity.RoomNumber;
            if(entity.Seat==1)
            {
                room.Status = 0;
            }
            else if(entity.Seat==2)
            {
                room.Status = 1;
            }
            else
            {
                return false;
            }
                string sql2 = " Update Rooms Set Status='"+room.Status+"' Where RoomNumber='"+room.RoomNumber+"' ";
                db = new DataAccess();
                int result2 = db.ExecuteQuery(sql2);
                
                if (result > 0 && result2>0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool ExtraServicesUpdate(Patient entity)
        {
            
            try
            {
                db = new DataAccess();
                string sql = " Update Patients Set OT='" + entity.OT + "',ExtraServices='" + entity.ExtraServices + "',TotalCost='" + entity.TotalCost + "'Where Id='" + entity.Id + "'  ";
                int result = db.ExecuteQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool PrescriptionUpdate(Patient entity)
        {

            try
            {
                db = new DataAccess();
                string sql = " Update Patients Set Prescription='" + entity.Prescription + "'Where Id='" + entity.Id + "'  ";
                int result = db.ExecuteQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public bool ConditionUpdate(Patient entity)
        {

            db = new DataAccess();
            string sql = " Update Patients Set ReadyToRelease='" + entity.ReadyToRelease + "',ReleaseCondition='" + entity.ReleaseCondition + "'Where Id='" + entity.Id + "'  ";
            int result = db.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }

        public bool Delete(Patient entity)
        {
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
    }
