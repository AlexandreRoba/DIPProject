using System.Collections.Generic;

namespace DIPProject.BAD.Model
{
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }

        public Cart()
        {
            this.Items = new List<OrderItem>();
        }
    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}