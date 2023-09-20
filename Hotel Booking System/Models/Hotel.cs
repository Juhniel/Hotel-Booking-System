using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Url]
        public string Website { get; set; }

        [Required]
        public string Location { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Range(0, 5)]
        public float Rating { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}
