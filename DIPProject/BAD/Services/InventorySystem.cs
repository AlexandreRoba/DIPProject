using System;

namespace DIPProject.BAD.Services
{
    public class InventorySystem
    {
        public void Reserve(string sku, int quantity)
        {
            throw new InsufficientInventoryException();
        }
    }

    public class InsufficientInventoryException : Exception
    {
    }
}