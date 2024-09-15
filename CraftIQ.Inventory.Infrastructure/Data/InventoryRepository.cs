using huzcodes.Persistence.Implementations.EfRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Infrastructure.Data
{
    public class InventoryRepository<TEntity> : HuzcodesRepository<TEntity> where TEntity : class
    {
        public InventoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
