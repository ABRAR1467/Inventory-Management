using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class SalesOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int CustomerId { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset DeliveryDate { get; set; }
        public int CurrencyId { get; set; }
        public int SalesTypeId { get; set; }
        public string Remarks { get; set; }
        public double Amount { get; set; }
        public double SubTotal { get; set; }
        public double Discount { get; set; }
        public double tax { get; set; }
        public double Total { get; set; }


    }
}
