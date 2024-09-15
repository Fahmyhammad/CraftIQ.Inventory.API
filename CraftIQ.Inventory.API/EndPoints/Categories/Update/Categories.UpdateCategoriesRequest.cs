using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Update
{
    public class UpdateCategoriesRequest
    {
        [FromRoute]
        public Guid categoryId { get; set; }
        [FromBody]
        public Body Category { get; set; }
    }

    public class Body
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
