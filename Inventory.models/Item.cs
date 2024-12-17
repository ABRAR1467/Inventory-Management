using Inventory.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AvailQuantity { get; set; }
        public Status Status { get; set; }

    }
}
namespace Inventory.models
{
    public enum Status
    {
        OK, Deefective
    }
}
