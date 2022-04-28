using MongoDB.Bson;
using MongoDB.Driver;
namespace Raspisanie.Classes

{
    public class Lesson
    {
        public Lesson(string name)
        {
            Name = name;
        }
        public ObjectId _id { get; set; }
        public string Name { get; set; }
    }
}
