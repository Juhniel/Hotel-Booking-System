using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime ? CreatedAt { get; set; } 
        public DateTime ? CancelledAt { get; set; }
        public DateTime ? UpdatedAt { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public bool IsPaid { get; set; }
        public User User { get; set; }
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
        public Payment Payment { get; set; }
        public int UserId { get; set; } // Foreign key
        public int HotelId { get; set; } // Foreign key    
        public int RoomId { get; set; } // Foreign key
        public int PaymentId { get; set; } // Foreign key
    }

    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled,
        CheckedIn,
        CheckedOut
    }
}
