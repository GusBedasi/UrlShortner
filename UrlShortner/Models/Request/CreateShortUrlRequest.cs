using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UrlShortner.Models.Request
{
    public class CreateShortUrlRequest : ICreateShortUrlRequest
    {
        [Required]
        [JsonProperty("original_url")]
        public string OriginalUrl { get; set; }
    }
}
