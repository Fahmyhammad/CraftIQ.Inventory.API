using Ardalis.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Entities.Categories.Specifications
{
    public class ReadAllSpecification : Specification<Category>
    {
        public ReadAllSpecification()
        {

            Query.Where(o => o.Id != 0);
        }
    }
}
