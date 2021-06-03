using Newtonsoft.Json;
using System;

namespace UrlShortner.Models
{
    public class CreateShortUrlResponse : ICreateShortUrlResponse
    {
        [JsonProperty("short_url")]
        public string ExternalId { get; set; }
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
