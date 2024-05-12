﻿using LePicka.Shared.Repository;

namespace LePickaOrders.Domain.Products
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int ExternalId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
