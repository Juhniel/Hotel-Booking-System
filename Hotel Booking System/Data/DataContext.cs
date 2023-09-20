using Hotel_Booking_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_Booking_System.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User to Booking
            // One-to-Many
            // Booking table has foreign key with UserId
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId);

            // Booking to Hotel
            // Many-to-One
            // Booking table has a foreign key with HotelId
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Hotel)
                .WithMany(h => h.Bookings)
                .HasForeignKey(b => b.HotelId);

            // Booking-to-Room
            // Many-to-One
            // Booking table has roomId foreign key
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany(r => r.Bookings)
                .HasForeignKey(b => b.RoomId);

            // Booking-to-Payment
            // One-to-One
            // Booking table has a paymentId foreign key
            modelBuilder.Entity<Booking>()
                 .HasOne(b => b.Payment)
                 .WithOne(p => p.Booking)
                 .HasForeignKey<Booking>(b => b.PaymentId);

            // Hotel-to-Room
            // One-to-Many
            // Room table has a HotelId foreign key
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId);

            // User-to-Payment
            // One-to-Many
            // Payment table has a UserId foreign key
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments) 
                .HasForeignKey(p => p.UserId);
        }
    }
}
