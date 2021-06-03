using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace UrlShortner.Models.Entities
{
    public class Url
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public string UrlExternalId { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Hash { get; set; }
    }
}
