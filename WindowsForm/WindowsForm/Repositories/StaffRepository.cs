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
    public class StaffRepository : IRepository<Staff>, IDisposable
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Staff> GetAll()
        {
            string sql = "Select * From Staffs";
            reader = db.GetData(sql);
            List<Staff> allstaff = new List<Staff>();
            while (reader.Read())
            {
                Staff staff = new Staff();
                staff.Name = reader["Name"].ToString();
                staff.Gender = reader["Gender"].ToString();
                staff.Phone = reader["Phone"].ToString();
                staff.Address = reader["Address"].ToString();
                staff.Dob = reader["DoB"].ToString();
                staff.Salary = Convert.ToDouble(reader["Salary"]);
                allstaff.Add(staff);
            }
            return allstaff;
        }
        public Staff Get(Staff entity)
        {
            try
            {
                string sql = " Select * From Staffs Where Phone='" + entity.Phone + "'";
                reader = db.GetData(sql);
                while (reader.Read())
                {
                    entity.Name = reader["Name"].ToString();
                    entity.Gender = reader["Gender"].ToString();
                    entity.Phone = reader["Phone"].ToString();
                    entity.Address = reader["Address"].ToString();
                    entity.Dob = reader["DoB"].ToString();
                    entity.Salary = Convert.ToDouble(reader["Salary"]);
                }
                return entity;
            }
            catch (Exception )
            {
                return null;
            }
        }
        public bool Insert(Staff entity)
        {
            try
            {
                string sql = "Insert Into Staffs Values('" + entity.Name + "','" + entity.Gender + "','" + entity.Phone + "','" + entity.Address + "','" + entity.Dob + "','" + entity.Salary + "')";
                Login login = new Login();
                login.UserName = entity.Phone;
                login.Passsword = entity.Password;
                login.UserType = 3;
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
            }
            catch (Exception )
            {
                return false;
            }
        }
        public bool Update(Staff entity)
        {
            try
            {
                string sql = " Update Staffs Set Name='" + entity.Name + "',Gender='" + entity.Gender + "',Address='" + entity.Address + "',Salary='" + entity.Salary + "' Where Phone='" + entity.Phone + "' ";
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

        public bool UpdatePass(Staff entity)
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

        public bool UpdatePass(Admin entity)
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





        public bool Delete(Staff entity)
        {
            try
            {
                string sql = "Delete From Staffs Where Phone='" + entity.Phone + "'";
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
