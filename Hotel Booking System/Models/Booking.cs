using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        public DateTime ? CreatedAt { get; set; } 

        public DateTime ? CancelledAt { get; set; }

        public DateTime ? UpdatedAt { get; set; }

        public BookingStatus BookingStatus { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Number of guests must be at least 1")]
        public int NumberOfGuests { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Total amount must be non-negative")]
        public double TotalAmount { get; set; }

        public virtual User User { get; set; }

        public virtual Hotel Hotel { get; set; }

        public virtual Room Room { get; set; }

        public virtual Payment Payment { get; set; }

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
