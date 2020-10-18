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
    class DoctorRepository:IRepository<Doctor>, IDisposable
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Doctor> GetAll()
        {
            string sql = "Select * From Doctors";
            reader = db.GetData(sql);
            List<Doctor> allDoctor = new List<Doctor>();
            while (reader.Read())
            {
                
                    Doctor doctor = new Doctor();
                    doctor.Name = reader["Name"].ToString();
                    doctor.Gender = reader["Gender"].ToString();
                    doctor.Phone = reader["Phone"].ToString();
                    doctor.Address = reader["Address"].ToString();
                    doctor.Dob = reader["DoB"].ToString();
                    doctor.Salary = Convert.ToDouble(reader["Salary"]);
                    doctor.WId = Convert.ToInt32(reader["WId"]);
                    doctor.NotificationCount = Convert.ToInt32(reader["NotificationCount"]);
                    doctor.Notfication = reader["Notification"].ToString();
                    allDoctor.Add(doctor);
              
            }
            return allDoctor;
        }
        public Doctor Get(Doctor entity)
        {
            //try
            //{
                string sql = " Select * From Doctors Where Phone='" + entity.Phone + "'";
                reader = db.GetData(sql);
                while (reader.Read())
                {
                    entity.Name = reader["Name"].ToString();
                    entity.Gender = reader["Gender"].ToString();
                    entity.Phone = reader["Phone"].ToString();
                    entity.Address = reader["Address"].ToString();
                    entity.Dob = reader["DoB"].ToString();
                    entity.Salary = Convert.ToDouble(reader["Salary"]);
                    entity.WId = Convert.ToInt32(reader["WId"]);
                    entity.NotificationCount = Convert.ToInt32(reader["NotificationCount"]);
                    entity.Notfication = reader["Notification"].ToString();
                }
                return entity;
            //}
            //catch (Exception e)
            //{
            //    return null;
            //}
        }
        public bool Insert(Doctor entity)
        {
            //try
            //{
                string sql = "Insert Into Doctors Values('" + entity.Name + "','" + entity.Gender + "','" + entity.Phone + "','" + entity.Address + "','" + entity.Dob + "','" + entity.Salary + "' ,'" + entity.WId +"','"+entity.NotificationCount+"','"+entity.Notfication+"')";
                Login login = new Login();
                login.UserName = entity.Phone;
                login.Passsword = entity.Password;
                login.UserType = 2;
                int result = db.ExecuteQuery(sql);

                string sql2 = "Insert Into Login Values('" + login.UserName + "','" + login.Passsword + "','" + login.UserType + "')";
                db = new DataAccess();
                int result2 = db.ExecuteQuery(sql2);
                if (result > 0 && result2 > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
        }
        public bool Update(Doctor entity)
        {
            try
            {
                string sql = " Update doctors Set Name='" + entity.Name + "',Gender='" + entity.Gender + "',Address='" + entity.Address + "',Salary='" + entity.Salary + "' Where Phone='" + entity.Phone + "' ";
                int result = db.ExecuteQuery(sql);
                if (result > 0)
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
        public bool Delete(Doctor entity)
        {
            try
            {
                string sql = "Delete From Doctors Where Phone='" + entity.Phone + "'";
                int result = db.ExecuteQuery(sql);
                if (result > 0)
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

        public Doctor GetNotification(Doctor entity)
        {
            string sql = " Select NotificationCount,Notification From Doctors Where Phone='" + entity.Phone + "'";
            reader = db.GetData(sql);
            if (reader != null)
            {
                while (reader.Read())
                {
                    entity.Notfication = reader["Notification"].ToString();
                    if (reader["NotificationCount"] != null)
                    {
                        entity.NotificationCount = Convert.ToInt32(reader["NotificationCount"]);
                    }
                    else
                    {
                        entity.NotificationCount = 0;
                    }
                }
                return entity;
            }
            else
            {
                return null;
            }
        }

        public bool SetNotification(Doctor entity)
        {

            string sql = " Update doctors Set Notification='" + entity.Notfication + "',NotificationCount='" + entity.NotificationCount + "' Where Phone='" + entity.Phone + "' ";
            int result = db.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            else
                return false;
        }


        public bool UpdatePass(Doctor entity)
        {
            try
            {
                string sql = " Update Login Set Password='" + entity.Password + "' Where UserName='" + entity.Phone + "' ";
                int result = db.ExecuteQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception )
            {
                return false;
            }
        }


            public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
