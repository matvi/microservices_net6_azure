﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MICROSERVICE.AZ.Movement.ConfigCollection;
public interface IDocument
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    ObjectId Id { get; set; }

    DateTime CreatedAt { get; }
}

