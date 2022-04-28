using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Raspisanie.Classes
{
    public class Day
    {
        [BsonId] [BsonRepresentation(BsonType.ObjectId)] public string Id { get; set; }
    }
}
