using CraftIQ.Inventory.Infrastructure.Data;
using huzcodes.Persistence.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Infrastructure
{
    public static class InfrastructureRegistrations
    {
        public static void AddInventoryDbContext(this IServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(ConnectionString));
        }

        public static void AddInfrastructureRegistrations(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(InventoryRepository<>));
            services.AddScoped(typeof(IReadRepository<>), typeof(InventoryRepository<>));
        }
    }
}
