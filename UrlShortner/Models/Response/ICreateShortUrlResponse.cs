using System;

namespace UrlShortner.Models
{
    public interface ICreateShortUrlResponse
    {
        public string ShortUrl { get; set; }
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt { get; set; }
    }
}
