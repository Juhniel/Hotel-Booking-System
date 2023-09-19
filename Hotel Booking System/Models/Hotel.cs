using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public List<string> Amenities { get; set; } 
        public float Rating { get; set; }
        public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
