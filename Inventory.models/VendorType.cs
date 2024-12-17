using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class VendorType
    {
        public int VentorTypeId { get; set; }
        [Required]
        public string VentorTypeName { get; set; }
        public string Description { get; set; }

    }
}
