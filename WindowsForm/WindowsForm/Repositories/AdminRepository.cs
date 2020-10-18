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
    public class AdminRepository : IRepository<Admin>, IDisposable
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Admin> GetAll()
        {
            string sql = "Select * From Admins";
            reader = db.GetData(sql);
            List<Admin> allAdmin = new List<Admin>();
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin.Name = reader["Name"].ToString();
                admin.Gender = reader["Gender"].ToString();
                admin.Phone = reader["Phone"].ToString();
                admin.Address = reader["Address"].ToString();
                admin.Dob = reader["DoB"].ToString();
                admin.Salary = Convert.ToDouble(reader["Salary"]);
                allAdmin.Add(admin);
            }
            return allAdmin;
        }
        public Admin Get(Admin entity)
        {
            try
            {
                string sql = " Select * From Admins Where Phone='" + entity.Phone + "'";
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
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Insert(Admin entity)
        {
            try
            {
                string sql = "Insert Into Admins Values('" + entity.Name + "','" + entity.Gender + "','" + entity.Phone + "','" + entity.Address + "','" + entity.Dob + "','" + entity.Salary + "' )";
                Login login = new Login();
                login.UserName = entity.Phone;
                login.Passsword = entity.Password;
                login.UserType = 1;
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
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Update(Admin entity)
        {
            try
            {
                string sql = " Update Admins Set Name='" + entity.Name + "',Gender='" + entity.Gender + "',Address='" + entity.Address + "',Salary='" + entity.Salary + "' Where Phone='" + entity.Phone + "' ";
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

        public bool UpdatePass(Admin entity)
        {
            //try
            //{
                string sql = " Update Login Set Password='" + entity.Password + "' Where UserName='" + entity.Phone+ "' ";
                int result = db.ExecuteQuery(sql);
                if (result > 0)
                {
                    return true;
                }
                else
                    return false;
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
        }

        public bool Delete(Admin entity)
        {
            try
            {
                string sql = "Delete From Admins Where Phone='" + entity.Phone + "'";
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
