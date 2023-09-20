using Hotel_Booking_System.Models;
using Hotel_Payment_System.Interfaces;

namespace Hotel_Booking_System.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        public bool CreatePayment(Payment Payment)
        {
            throw new NotImplementedException();
        }

        public bool DeletePayment(int id)
        {
            throw new NotImplementedException();
        }

        public Payment GetPayment(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetPayments()
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetPaymentsByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetPaymentsByUser(User user)
        {
            throw new NotImplementedException();
        }

        public ICollection<Payment> GetPaymentsByUserName(string userName)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdatePayment(Payment Payment)
        {
            throw new NotImplementedException();
        }
    }
}
