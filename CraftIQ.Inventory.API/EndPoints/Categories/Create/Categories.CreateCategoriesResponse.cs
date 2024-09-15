using System.ComponentModel.DataAnnotations;

namespace CraftIQ.Inventory.API.EndPoints.Categories.Create
{
    public class CreateCategoriesRespones
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;


        public CreateCategoriesRespones(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
