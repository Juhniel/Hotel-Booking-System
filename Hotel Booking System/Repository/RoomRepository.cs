using Hotel_Booking_System.Models;
using Hotel_Room_System.Interfaces;

namespace Hotel_Booking_System.Repository
{
    public class RoomRepository : IRoomRepository
    {
        public bool CreateRoom(Room Room)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public Room GetRoom(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Room> GetRooms()
        {
            throw new NotImplementedException();
        }

        public ICollection<Room> GetRoomsByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ICollection<Room> GetRoomsByUser(User user)
        {
            throw new NotImplementedException();
        }

        public ICollection<Room> GetRoomsByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateRoom(Room Room)
        {
            throw new NotImplementedException();
        }
    }
}
