using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace MongoDB
{
    public interface IPeasant
    {
        ObjectId _id { get; set; }
        string Name { get; set; }
        double Health { get; set; }
        double MaxHealth { get; set; }
    }
}
