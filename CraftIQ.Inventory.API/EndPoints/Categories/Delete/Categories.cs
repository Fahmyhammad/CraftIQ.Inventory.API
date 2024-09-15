using CraftIQ.Inventory.Core.Interfaces;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Delete
{
    public class Categories(ICategoriesServices services) : EndpointsAsync.WithRequest<CategoriesDeleteRequest>.WithActionResult
    {
        private readonly ICategoriesServices _services = services;
        [HttpDelete(Routes.CategoryRoutes.Delete)]
        public override async Task<ActionResult> HandleAsync(CategoriesDeleteRequest request, CancellationToken cancellationToken = default)
        {
             await _services.DeleteCategory(request.categoryId);
            return Ok("Your object deleted successfully");
        }
    }
}
