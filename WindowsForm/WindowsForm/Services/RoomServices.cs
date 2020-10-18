using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm.Entities;
using WindowsForm.Repositories;

namespace WindowsForm.Services
{
    public class RoomServices
    {
        RoomRepository roomRepository = new  RoomRepository();

        public bool Add(Room  room)
        {
            return roomRepository.Insert(room);
        }
        public List<Room> GetAll()
        {
            return roomRepository.GetAll();
        }
        public Room Get(Room room)
        {
            return roomRepository.Get(room);
        }

        public Room GetByRoomNumber(Room room)
        {
            return roomRepository.GetByRoomNumber(room);
        }

        public List<Room> GetAllWId(Ward ward)
        {
            return roomRepository.GetAllWId(ward);
        }

        public Ward GetWId(Ward ward)
        {
            return roomRepository.GetWId(ward);
        }

        public bool Update(Room room)
        {
            return roomRepository.Update(room);
        }

        public bool UpdateStatus(Room entity)
        {
            return roomRepository.UpdateStatus(entity);
        }
    }
}
