﻿using Framework.Domain;
using System;

namespace ShoeStore.Products.Domain
{
    public class Product : IAggregateRoot
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Rank { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Cost { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public AuditInfo AuditInfo { get; set; }
    }
}
