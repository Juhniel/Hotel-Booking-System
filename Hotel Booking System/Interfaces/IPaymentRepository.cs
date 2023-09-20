using Hotel_Booking_System.Models;

namespace Hotel_Payment_System.Interfaces
{
    public interface IPaymentRepository
    {
        ICollection<Payment> GetPayments();
        Payment GetPayment(int id);
        ICollection<Payment> GetPaymentsByUser(User user);
        ICollection<Payment> GetPaymentsByUserName(string userName);
        ICollection<Payment> GetPaymentsByEmail(string email);
        bool CreatePayment(Payment Payment);
        bool UpdatePayment(Payment Payment);
        bool DeletePayment(int id);
        bool Save();
    }
}
