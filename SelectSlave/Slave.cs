using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace SelectSlave
{
    public class Slave
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int IdGroup { get; set; }

        public Slave() { }

        public Slave(string firstName, string lastName, int group)
        {
            FirstName = firstName;
            LastName = lastName;
            IdGroup = group;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }
    }
}
