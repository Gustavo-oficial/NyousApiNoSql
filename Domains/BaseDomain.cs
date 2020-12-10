﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace NyousApi.NoSql.Domains
{
    public class BaseDomain
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

    }
}
