namespace UrlShortner.Models.Entities
{
    public class Url
    {
        public string UserId { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }
        public string Hash { get; set; }
    }
}
