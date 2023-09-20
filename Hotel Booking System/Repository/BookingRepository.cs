using Hotel_Booking_System.Data;
using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly DataContext _context;

        public BookingRepository(DataContext context)
        {
            _context=context;
        }

        public bool BookingExists(int id)
        {
            return _context.Bookings.Any(b => b.Id == id);
        }

        public bool CreateBooking(Booking booking)
        {
            _context.Add(booking);
            return Save();
        }

        public bool DeleteBooking(int id)
        {
            
            return Save();
        }

        public Booking GetBooking(int id)
        {
            return _context.Bookings.Where(b => b.Id == id).FirstOrDefault();
        }

        public ICollection<Booking> GetBookings()
        {
            return _context.Bookings.ToList();
        }

        public ICollection<Booking> GetBookingsByEmail(string email)
        {
            return _context.Bookings.Where(u => u.User.Email == email).ToList();
        }

        public ICollection<Booking> GetBookingsByUserId(int userId)
        {
            return _context.Bookings.Where(u => u.User.Id == userId).ToList();
        }

        public ICollection<Booking> GetBookingsByUserName(string userName)
        {
            return _context.Bookings.Where(u => u.User.Username == userName).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateBooking(Booking booking)
        {
            _context.Update(booking);
            return Save();
        }
    }
}
