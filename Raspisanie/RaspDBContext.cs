using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raspisanie.Shared.Models
{
    public class RaspDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public RaspDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("Raspisanie");
        }
        public IMongoCollection<Day> DayRecord { get { return _mongoDatabase.GetCollection<Day>("Days"); } }
        public IMongoCollection<Lesson> LessonRecord
        {
            get
            {
                return _mongoDatabase.GetCollection<Lesson>("Lessons");
            }
        }
    }
}
