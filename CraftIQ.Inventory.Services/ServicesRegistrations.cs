using CraftIQ.Inventory.Core.Interfaces;
using CraftIQ.Inventory.Services.CategoriesImplementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Services
{
    public static class ServicesRegistrations
    {
        public static void AddServicesRegistrations(this IServiceCollection services)
        {
            services.AddScoped<ICategoriesServices, CategoriesServices>();
        }
    }
}
