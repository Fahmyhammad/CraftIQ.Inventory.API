using Microsoft.AspNetCore.Mvc;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Delete
{
    public class CategoriesDeleteRequest
    {
        [FromRoute]
        public Guid categoryId {  get; set; }
    }
}
