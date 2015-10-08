using System.Collections.Generic;
using DIPProject.Solution.Model;

namespace DIPProject.Solution.Interfaces
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}