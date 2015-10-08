using DIPProject.Solution.Model;

namespace DIPProject.Solution.Interfaces
{
    public interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}