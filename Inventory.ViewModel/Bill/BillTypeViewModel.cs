using Inventory.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ViewModel.Bill
{
    public class BillTypeViewModel
    {
        public int BillTypeId { get; set; }
        public string BillTypeName { get; set; }
        public string Description { get; set; }

        public BillTypeViewModel(BillType model)
        {
            BillTypeId = model.BillTypeId;
            BillTypeName = model.BillTypeName;
            Description = model.Description;
        }
    }
}
