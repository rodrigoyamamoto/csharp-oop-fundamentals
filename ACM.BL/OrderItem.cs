using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public bool Validade()
        {
            var isValid = true;

            if (Quantity <= 0 || ProductId <= 0 || PurchasePrice == null)
                isValid = false;

            return isValid;
        }

        public bool Save()
        {
            return true;
        }

        public Order Retrieve()
        {
            return new Order();
        }

        public List<Order> Retrieve(int orderId)
        {
            return new List<Order>();
        }

    }
}
