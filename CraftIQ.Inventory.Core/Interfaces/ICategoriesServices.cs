using CraftIQ.Inventory.Shared.Contracts.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Interfaces
{
    public interface ICategoriesServices
    {
        ValueTask<CategoriesOperationsContract> CreateCategory(CategoriesOperationsContract contract);
        ValueTask<List<CategoriesContract>> ReadCategories();
        ValueTask<CategoriesContract> ReadCategoriesById(Guid CategoryId);
        ValueTask UpdateCategory(Guid CategoryId, CategoriesOperationsContract contract);
        ValueTask DeleteCategory(Guid CategoryId);
    }
}
