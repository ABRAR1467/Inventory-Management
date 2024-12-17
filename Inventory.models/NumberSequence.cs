using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.models
{
    public class NumberSequence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Module { get; set; }
        public string Prefix { get; set; }
        public int LastNumber { get; set; }

    }
}
