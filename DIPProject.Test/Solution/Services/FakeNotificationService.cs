using DIPProject.Solution.Interfaces;
using DIPProject.Solution.Model;

namespace DIPProject.Test.Solution.Services
{
    class FakeNotificationService : INotificationService
    {
        public bool WasCalled = false;
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            WasCalled = true;
        }
    }
}