using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UrlShortner.Models.Request
{
    public class CreateShortUrlRequest : ICreateShortUrlRequest
    {
        public string UserId { get; set; }
        [Required]
        [JsonProperty("original_url")]
        public string OriginalUrl { get; set; }
    }
}
