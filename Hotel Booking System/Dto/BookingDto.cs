using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Dto
{
    public class BookingDto
    {
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public int NumberOfGuests { get; set; }
        public double TotalAmount { get; set; }

        
        public int UserId { get; set; } 
        public int HotelId { get; set; } 
        public int RoomId { get; set; } 
        public int PaymentId { get; set; } 
    }
}
