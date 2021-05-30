namespace UrlShortner.Models
{
    public interface ICreateShortUrlResponse
    {
        public string Id { get; set; }
        public string ShortUrl { get; set; }
    }
}
