using Newtonsoft.Json;

namespace UrlShortner.Models
{
    public class CreateShortUrlResponse : ICreateShortUrlResponse
    {
        [JsonProperty("user_id")]
        public string Id { get; set; }
        [JsonProperty("short_url")]
        public int ShortUrl { get; set; }
    }
}
