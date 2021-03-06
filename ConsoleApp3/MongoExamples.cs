using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class SubEntity
    {
        public SubEntity(string nameOfSubEntity, int numberOfSubEntity)
        {
            NameOfSubEntity = nameOfSubEntity;
            NumberOfSubEntity = numberOfSubEntity;
        }

        public string NameOfSubEntity { get; set; }
        public int NumberOfSubEntity { get; set; }
    }
    class Entity
    {
        public Entity(string nameOfEntity, int numberOfEntity)
        {
            NameOfEntity = nameOfEntity;
            NumberOfEntity = numberOfEntity;
            ListOfSubEntities = new List<SubEntity>();
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [BsonIgnoreIfDefault]
        public string NameOfEntity { get; set; }
        [BsonIgnoreIfDefault]
        public int NumberOfEntity { get; set; }
        [BsonIgnoreIfDefault]
        public int NumberOfReferenses { get; set; }
        [BsonIgnoreIfNull]
        public List<SubEntity> ListOfSubEntities { get; set; }
    }
    class MongoExamples
    {
        static Entity CreateEntity()
        {
            SubEntity sub1 = new SubEntity("Alpha", 1);
            SubEntity sub2 = new SubEntity("Beta", 2);
            SubEntity sub3 = new SubEntity("Gamma", 3);

            Entity entity1 = new Entity("EpsilonEntity", 10);
            entity1.ListOfSubEntities.Add(sub1);
            entity1.ListOfSubEntities.Add(sub2);
            entity1.ListOfSubEntities.Add(sub3);

            return entity1;
        }

        public static async Task AddToMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320GroupTest");
            var collection = database.GetCollection<Entity>("TestEntities");
            await collection.InsertOneAsync(CreateEntity());
        }

        public static async Task GetAllFromMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320GroupTest");
            var collection = database.GetCollection<Entity>("TestEntities");
            var list = await collection.Find(x => true).ToListAsync();

            foreach (var item in list)
            {
                System.Console.WriteLine($"{item.NameOfEntity}");
            }
        }

        public static async Task UpdateMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320GroupTest");
            var collection = database.GetCollection<Entity>("TestEntities");
            var definition = Builders<Entity>.Update.Set(x => x.NumberOfReferenses, "BetaEntity");
            await collection.UpdateOneAsync(x => x.NameOfEntity == "EpsilonEntity", definition);
            
        }

    }
}
