﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftIQ.Inventory.Core.Entities
{
    public class OrderDetail : BaseEntity
    {
        public Guid OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice {  get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}
