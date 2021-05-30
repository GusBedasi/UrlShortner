using Newtonsoft.Json;

namespace UrlShortner.Models
{
    public class CreateShortUrlResponse
    {
        [JsonProperty("user_id")]
        public string Id { get; set; }
        [JsonProperty("short_url")]
        public string ShortUrl { get; set; }
    }
}
