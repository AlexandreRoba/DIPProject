using System.Collections.Generic;
using DIPProject.Solution.Interfaces;
using DIPProject.Solution.Model;

namespace DIPProject.Solution.Services
{
    class FakeReservationService : IReservationService
    {
        public bool WasCalled = false;
        public void ReserveInventory(IEnumerable<OrderItem> items)
        {
            WasCalled = true;
        }
    }
}