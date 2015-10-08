using DIPProject.Solution.Model;

namespace DIPProject.Solution.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}