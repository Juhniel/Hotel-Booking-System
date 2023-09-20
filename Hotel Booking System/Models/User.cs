using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_System.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Roles Roles { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    public enum Roles
    {
        Guest,
        Staff,
        HotelManager,
        Administrator
    }
}
