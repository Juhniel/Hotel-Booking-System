using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public RoomType RoomType { get; set; }

        [Range(1, Int32.MaxValue)]
        public int MaxOccupancy { get; set; }

        public int Floor {  get; set; }

        [Range(0, double.MaxValue)]

        public double Price { get; set; }

        public bool IsAvailable { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

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
