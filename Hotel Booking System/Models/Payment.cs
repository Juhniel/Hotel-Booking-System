using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public double ? PaymentAmount { get; set; }
        public Booking Booking { get; set; }
        public User User { get; set; }
        public int UserId { get; set; } // Foreign key
        public int BookingId { get; set; } // Foreign key

    }

    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        PayPal,
        Cash
    }

    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed
    }
}
