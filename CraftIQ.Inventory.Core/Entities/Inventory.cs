using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Entities
{
    public class Inventory : BaseEntity
    {
        public Inventory()
        {
        }
      
        public Guid InventoryId { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTimeOffset LastUpdated { get; set; }

        public List<Product> Products { get; set; }

    }
}
