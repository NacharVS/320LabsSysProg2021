using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Raspisanie.Shared.Models
{
    public class Day
    {
        [BsonId] [BsonRepresentation(BsonType.ObjectId)] public string Id { get; set; }
        public string Name { get; set; }

        public Day(string name)
        {
            Name = name;
        }
    }
}
