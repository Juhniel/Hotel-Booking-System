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
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Roles Roles { get; set; }
    }

    public enum Roles
    {
        Guest,
        Staff,
        HotelManager,
        Administrator
    }
}
