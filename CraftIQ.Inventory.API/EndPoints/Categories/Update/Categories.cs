﻿using CraftIQ.Inventory.Core.Interfaces;
using CraftIQ.Inventory.Shared.Contracts.Categories;
using huzcodes.Endpoints.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Update
{
    public class Categories(ICategoriesServices services) : EndpointsAsync.WithRequest<UpdateCategoriesRequest>.WithActionResult
    {
        private readonly ICategoriesServices _services = services;
        [HttpPut(Routes.CategoryRoutes.Update)]
        public override async Task<ActionResult> HandleAsync(UpdateCategoriesRequest request, CancellationToken cancellationToken = default)
        {
            var oData = new CategoriesOperationsContract(request.Category.Name,request.Category.Description);
             await _services.UpdateCategory(request.categoryId, oData);

            return Ok("your object has been updated");
        }
    }
}
