﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Demo.Models
{
    public class Sport
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        public string Title { get; set; }

        public int TotalEvents { get; set; }
    }
}
