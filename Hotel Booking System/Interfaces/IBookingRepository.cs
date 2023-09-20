using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IBookingRepository
    {
        ICollection<Booking> GetBookings();
        Booking GetBooking(int id);
        ICollection<Booking> GetBookingsByUserId(int userId);
        ICollection<Booking> GetBookingsByUserName(string userName);
        ICollection<Booking> GetBookingsByEmail(string email);
        bool BookingExists(int id);
        bool CreateBooking (Booking booking);
        bool UpdateBooking (Booking booking);
        bool DeleteBooking (int id);
        bool Save();
    }
}
