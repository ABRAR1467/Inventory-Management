using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Bill
{
    public class BillListViewModel
    {
        public int BillId { get; set; }
        [Display(Name = "Bill / Invoice Number")]
        public string BillName { get; set; }
        [Display(Name = "GRN")]
        public int GoodsReceivedNotedId { get; set; }
        [Display(Name = "Vendor Delivery Order")]
        public string VendorDoNumber { get; set; }
        [Display(Name = "Vendor Bill / Ivoice")]
        public string VendorInvoiceNumber { get; set; }
        [Display(Name = "Bill Date")]
        public DateTimeOffset BillDate { get; set; }
        [Display(Name = "Bill Due Date")]
        public DateTimeOffset BillDueDate { get; set; }
        [Display(Name = "Bill Type")]
        public int BillTypeId { get; set; }

    }
}
