using System.Collections.Generic;
using System.Linq;

public class Order
{
    public List<OrderItem> Items { get; set; } = new List<OrderItem>();

    public class OrderItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }
    }
}