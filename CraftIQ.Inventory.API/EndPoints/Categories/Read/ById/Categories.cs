using CraftIQ.Inventory.Core.Interfaces;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Read.ById
{
    public class Categories(ICategoriesServices services) : EndpointsAsync.WithRequest<ReadCategoriesByIdRequest>.WithActionResult<ReadCategoriesByIdResponse>
    {
        private readonly ICategoriesServices _services = services;


        [HttpGet(Routes.CategoryRoutes.ReadById)]
        public override async Task<ActionResult<ReadCategoriesByIdResponse>> HandleAsync(ReadCategoriesByIdRequest request, CancellationToken cancellationToken = default)
        {
            var oData = await _services.ReadCategoriesById(request.CategoryId);
            var oResult = new ReadCategoriesByIdResponse(oData);
            return Ok(oResult);
        }
    }
}
