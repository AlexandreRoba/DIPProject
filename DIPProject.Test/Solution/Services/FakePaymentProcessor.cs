using DIPProject.Solution.Interfaces;
using DIPProject.Solution.Model;

namespace DIPProject.Test.Solution.Services
{
    class FakePaymentProcessor : IPaymentProcessor
    {
        public decimal AmountPassed = 0;
        public bool WasCalled = false;
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            WasCalled = true;
            AmountPassed = amount;
        }
    }
}