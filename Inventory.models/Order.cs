using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class Order
    {
        public int id;
        public int UserId { get; set; }
        public OrderType OrderType { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public decimal SubTotal { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal Tax { get; set; }
        public decimal ShippingCharges { get; set; }
        public decimal Total { get; set; }
        public string PromoCode { get; set; }
        public decimal Discount { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
namespace Inventory.models
{
    public enum OrderStatus
    {
        Checkout, Paid, Failed, Shipped, Delivered, Returned, Complete
    }
}

namespace Inventory.models
{
    public enum OrderType
    {
        PurchaseOrder, CustomerOrder
    }
}