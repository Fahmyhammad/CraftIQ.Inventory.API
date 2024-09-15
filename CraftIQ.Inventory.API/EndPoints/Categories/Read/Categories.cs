using CraftIQ.Inventory.Core.Interfaces;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Read
{
    public class Categories(ICategoriesServices services) : EndpointsAsync.WithoutRequest.WithActionResult<ReadCategoriesResponse>
    {
        private readonly ICategoriesServices _services = services;
        [HttpGet(Routes.CategoryRoutes.BaseUrl)]
        public override async Task<ActionResult<ReadCategoriesResponse>> HandleAsync(CancellationToken cancellationToken = default)
        {
            var oData = await _services.ReadCategories();
            var oResult = oData.Select(o => new ReadCategoriesResponse(o)).ToList();
            return Ok(oData);
        }
    }
}
