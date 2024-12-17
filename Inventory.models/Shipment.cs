using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class Shipment
    {
        public int Id { get; set; }
        [Display(Name = "Shipment Number")]
        public string ShipmentName { get; set; }
        [Display(Name = "Sales Order")]
        public int SalesOrderId { get; set; }
        [Display(Name = "Shipment Type")]
        public DateTimeOffset ShipmentDate { get; set; }
        public int ShipmentTypeId { get; set; }
        [Display(Name = "Warehouse")]
        public int WarehouseId { get; set; }
        [Display(Name = "Full Shipment")]
        public bool IsFullShipment { get; set; }
    }
}
