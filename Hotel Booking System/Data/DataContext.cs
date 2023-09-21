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
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Cascading delete from User to Booking

            // Booking to Hotel
            // Many-to-One
            // Booking table has a foreign key with HotelId
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Hotel)
                .WithMany(h => h.Bookings)
                .HasForeignKey(b => b.HotelId)
                .OnDelete(DeleteBehavior.NoAction); // No action when a Hotel is deleted

            // Booking-to-Room
            // Many-to-One
            // Booking table has roomId foreign key
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.Room)
                .WithMany(r => r.Bookings)
                .HasForeignKey(b => b.RoomId)
                .OnDelete(DeleteBehavior.NoAction); // No action when a Room is deleted

            // Booking-to-Payment
            // One-to-One
            // Booking table has a paymentId foreign key
            modelBuilder.Entity<Booking>()
                 .HasOne(b => b.Payment)
                 .WithOne(p => p.Booking)
                 .HasForeignKey<Booking>(b => b.PaymentId)
                 .OnDelete(DeleteBehavior.Cascade); // Cascading delete from Booking to Payment

            // Hotel-to-Room
            // One-to-Many
            // Room table has a HotelId foreign key
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade); // Cascading delete from Hotel to Room

            // User-to-Payment
            // One-to-Many
            // Payment table has a UserId foreign key
            modelBuilder.Entity<Payment>()
                .HasOne(p => p.User)
                .WithMany(u => u.Payments) 
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.NoAction); // No action when a User is deleted
        }
    }
}
