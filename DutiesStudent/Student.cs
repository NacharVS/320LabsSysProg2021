
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace DutiesStudent
{
    class Student
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname}";
        }
    }
}
