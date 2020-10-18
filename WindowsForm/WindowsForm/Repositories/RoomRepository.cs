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
    public class RoomRepository : IRepository<Room>, IDisposable
    {
        DataAccess db = new DataAccess();
        SqlDataReader reader;

        public List<Room> GetAll()
        {
            try
            {
                string sql = "Select * From Rooms";
                reader = db.GetData(sql);
                List<Room> allEntity = new List<Room>();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.Id = Convert.ToInt32(reader["Id"]);
                    room.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                    room.Type = reader["Type"].ToString();
                    room.Price = Convert.ToDouble(reader["Price"]);
                    room.Status = Convert.ToInt32(reader["Status"]);
                    room.WId = Convert.ToInt32(reader["WId"]);

                    allEntity.Add(room);
                }
                return allEntity;
            }
            catch(Exception e)
            {
                return null;
            }
        }

        public List<Room> GetAllWId(Ward ward)
        {
            //try
            //{
                string sql = "Select * From Rooms Where WId='" + ward.Id + "'";
                reader = db.GetData(sql);
                List<Room> allEntity = new List<Room>();
                while (reader.Read())
                {
                    Room room = new Room();
                    room.Id = Convert.ToInt32(reader["Id"]);
                    room.Type = reader["Type"].ToString();
                    room.Price = Convert.ToDouble(reader["Price"]);
                    room.Status = Convert.ToInt32(reader["Status"]);
                    room.RoomNumber = Convert.ToInt32(reader["RoomNumber"]);
                    room.WId = Convert.ToInt32(reader["WId"]);

                    allEntity.Add(room);
                }
                return allEntity;
            //}
            //catch(Exception e)
            //{
            //    return new List<Room>();
            //}
        }

        public Room Get(Room entity)
        {
            try
            {
                string sql = " Select * From Rooms Where Id='" + entity.Id + "'";
                reader = db.GetData(sql);
                Room room = new Room();
                while (reader.Read())
                {
                    
                    room.Id = Convert.ToInt32(reader["Name"]);
                    room.Type = reader["Type"].ToString();
                    room.Price = Convert.ToDouble(reader["Price"]);
                    room.Status = Convert.ToInt32(reader["Status"]);
                    room.WId = Convert.ToInt32(reader["WId"]);
                }
                return room;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Room GetByRoomNumber(Room entity)
        {
            try
            {
                string sql = " Select * From Rooms Where RoomNumber='" + entity.RoomNumber + "'";
                reader = db.GetData(sql);
                Room room = new Room();
               
                while (reader.Read())
                {   
                    room.Type = reader["Type"].ToString();
                    room.Status = Convert.ToInt32(reader["Status"]);
                    room.WId = Convert.ToInt32(reader["WId"]);

                }
            
            return room;
            }
            catch (Exception e)
            {
                return null;
            }
        }




        public bool Insert(Room entity)
        {
            if(entity.Type=="VIP")
            {
                entity.Price = 2000;
            }
            else
            {
                entity.Price = 1000;
            }

            entity.Status = 0;

            try
            {
                string sql = "Insert Into Rooms (RoomNumber,Type,Price,Status,WId) Values('" + entity.RoomNumber + "','"+ entity.Type+"' , '" +entity.Price +"' ,'" +entity.Status +"' ,'" +entity.WId +"')";

                db = new DataAccess();
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
        public bool Update(Room entity)
        {
           
            try
            {
                if (entity.Type == "VIP")
                {
                    entity.Price = 2000;
                }
                else
                {
                    entity.Price = 1000;
                }
                string sql = " Update Rooms Set Type='" + entity.Type + "', Price='"+entity.Price+"' ";
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

        public bool UpdateStatus(Room entity)
        {

            try
            {
               
                string sql = " Update Rooms Set Status='" + entity.Status + "'Where RoomNumber='"+entity.RoomNumber+"' ";
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


        public bool Delete(Room entity)
        {
            return true;
        }

        public Ward  GetWId(Ward entity)
        {
            try
            {
                string sql = " Select * From Wards Where Name='" + entity.Name + "'";
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

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
