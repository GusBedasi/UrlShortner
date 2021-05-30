using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace UrlShortner.Models.Request
{
    public class CreateShortUrlRequest : ICreateShortUrlRequest
    {
        public string UserId { get; set; }
        [Required]
        [JsonProperty("url")]
        [StringLength(12)]
        public string Url { get; set; }
    }
}
