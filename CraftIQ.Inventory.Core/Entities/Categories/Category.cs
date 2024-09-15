﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Entities.Categories
{
    public class Category : BaseEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public List<Product> products { get; set; } = new();

        public Category() { } // For EF Core

        public Category(string name, string description)
        {
            CategoryId = Guid.NewGuid();
            Name = name;
            Description = description;
            CreatedBy = Guid.Empty;
            CreatedOn = DateTimeOffset.Now;
            ModifiedBy = Guid.Empty;
            ModifiedOn = DateTimeOffset.Now;
        }

        public void  UpdateCategory(string name, string description,Guid modifiedBy)
        {
            Name = name;
            Description = description;
            ModifiedBy = modifiedBy;
            ModifiedOn = DateTimeOffset.Now;
        }
    }
}
