using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(int id);
        User GetUserByFirstName(string firstName);
        User GetUserByPhoneNumber(string phoneNumber);
        User GetUserByEmail(string email);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        bool UserExists(int id);
        bool EmailExists(string email);
        User ValidateUser(string email, string password);
    }
}
