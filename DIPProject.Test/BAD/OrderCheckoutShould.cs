using DIPProject.BAD.Model;
using NUnit.Framework;

namespace DIPProject.BAD
{
    [TestFixture]
    public class OrderCheckoutShould
    {
        [Test]
        public void NotFailWithNoItemsNoNotificationNoCreditCard()
        {
            var order = new Order();
            var cart = new Cart();
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };
            bool shouldNotifyCustomer = false;

            order.Checkout(cart, paymentDetails, shouldNotifyCustomer);

            // if I got here, I guess it worked...
        }

        [Test]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var order = new Order();
            var cart = new Cart() { CustomerEmail = "someone@nowhere.com" };
            var paymentDetails = new PaymentDetails() { PaymentMethod = PaymentMethod.Cash };
            bool shouldNotifyCustomer = true;

            order.Checkout(cart, paymentDetails, shouldNotifyCustomer);

            // if I got here, I guess it worked...
        }
    }
}
