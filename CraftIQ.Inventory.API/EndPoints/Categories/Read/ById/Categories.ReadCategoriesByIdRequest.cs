using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Read.ById
{
    public class ReadCategoriesByIdRequest
    {
        [FromRoute]
        public Guid CategoryId { get; set; }
    }
}
