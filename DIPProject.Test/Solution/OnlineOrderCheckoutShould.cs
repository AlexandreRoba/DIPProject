using DIPProject.Solution.Model;
using DIPProject.Solution.Services;
using DIPProject.Test.Solution.Services;
using NUnit.Framework;

namespace DIPProject.Solution
{
    [TestFixture]
    public class OnlineOrderCheckoutShould
    {
        [Test]
        public void SendTotalAmountToCreditCardProcessor()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationService = new FakeNotificationService();
            var cart = new Cart {TotalAmount = 5.05m};
            var paymentDetails = new PaymentDetails() 
            { PaymentMethod = PaymentMethod.CreditCard };
            var order = new OnlineOrder(cart,
                                        paymentDetails,
                                        paymentProcessor,
                                        reservationService,
                                        notificationService);

            order.Checkout();

            Assert.IsTrue(paymentProcessor.WasCalled);
            Assert.AreEqual(cart.TotalAmount, paymentProcessor.AmountPassed);

        }

        [Test]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var paymentProcessor = new FakePaymentProcessor();
            var reservationService = new FakeReservationService();
            var notificationService = new FakeNotificationService();
            var cart = new Cart() { CustomerEmail = "someone@nowhere.com" }; 
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.CreditCard };
            var order = new OnlineOrder(cart,
                                        paymentDetails,
                                        paymentProcessor,
                                        reservationService,
                                        notificationService);

            order.Checkout();

            // if I got here, I guess it worked...
        }
    }
}
