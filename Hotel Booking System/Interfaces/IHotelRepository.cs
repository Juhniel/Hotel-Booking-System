using Hotel_Booking_System.Models;

namespace Hotel_Hotel_System.Interfaces
{
    public interface IHotelRepository
    {
        ICollection<Hotel> GetHotels();
        Hotel GetHotel(int id);
        ICollection<Hotel> GetHotelsByName (string name);
        ICollection<Hotel> GetHotelsByLocation (string location);
        bool CreateHotel(Hotel Hotel);
        bool UpdateHotel(Hotel Hotel);
        bool DeleteHotel(int id);
        bool Save();
    }
}
