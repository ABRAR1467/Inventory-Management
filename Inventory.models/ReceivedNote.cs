using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class ReceivedNote
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PurchaseOrderId { get; set; }
        public DateTimeOffset GRNDate { get; set; }
        public string VendorNumber { get; set; }
        public string VendorInvoiceNumber { get; set; }
        public int WarehouseId { get; set; }
        public bool IdFullReceive { get; set; } = true;
    }
}
