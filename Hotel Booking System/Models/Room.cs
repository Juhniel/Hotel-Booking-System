using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public RoomType RoomType { get; set; }
        public int MaxOccupancy { get; set; }
        public int Floor {  get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public Hotel Hotel { get; set; }
        public int HotelId { get; set; } // Foreign key

    }

    public enum RoomType
    {
        SingleRoom,
        DoubleRoom,
        TripleRoom,
        DeluxeRoom,
        Suite,
        PresidentialSuite
    }
}
