﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id { get; set; }
        public string Name { get; init; }
        public decimal Price { get; init; } 

        public DateTimeOffset createDate { get; init; } 

    }
}
