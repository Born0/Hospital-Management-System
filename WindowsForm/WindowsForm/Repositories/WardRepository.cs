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
    public class WardRepository : IRepository<Ward>, IDisposable
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Ward> GetAll()
        {
            string sql = "Select * From Wards";
            reader = db.GetData(sql);
            List<Ward> allWards = new List<Ward>();
            while (reader.Read())
            {
                Ward  entity = new Ward();
                entity.Id =Convert.ToInt32 (reader["Id"]);
                entity.Name = reader["Name"].ToString();
               
                allWards.Add(entity);
            }
            return allWards;
        }
        public Ward Get(Ward entity)
        {
            try
            {
                string sql = " Select * From Wards Where Id='" + entity.Id + "'";
                reader = db.GetData(sql);
                while (reader.Read())
                {
                    entity.Id = Convert.ToInt32(reader["Id"]);
                    entity.Name = reader["Name"].ToString();

                }
                return entity;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool Insert(Ward entity)
        {
            try
            {
                string sql = "Insert Into Wards (Name) Values('" + entity.Name + "')";

                db = new DataAccess();
                int result = db.ExecuteQuery(sql);

                if (result > 0 )
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
        public bool Update(Ward entity)
        {
            return true;
        }
        public bool Delete(Ward entity)
        {
            return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

