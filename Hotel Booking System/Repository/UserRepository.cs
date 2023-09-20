using Hotel_Booking_System.Interfaces;
using Hotel_Booking_System.Models;

namespace Hotel_Booking_System.Repository
{
    public class UserRepository : IUserRepository
    {

        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool EmailExists(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public User GetUserByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }

        public User GetUserByPhoneNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> GetUsers()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UserExists(int id)
        {
            throw new NotImplementedException();
        }

        public User ValidateUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
