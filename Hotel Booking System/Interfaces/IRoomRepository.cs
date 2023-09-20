using Hotel_Booking_System.Models;

namespace Hotel_Room_System.Interfaces
{
    public interface IRoomRepository
    {
        ICollection<Room> GetRooms();
        Room GetRoom(int id);
        ICollection<Room> GetRoomsByUser(User user);
        ICollection<Room> GetRoomsByUserName(string userName);
        ICollection<Room> GetRoomsByEmail(string email);
        bool CreateRoom(Room Room);
        bool UpdateRoom(Room Room);
        bool DeleteRoom(int id);
        bool Save();
    }
}
