namespace UrlShortner.Models
{
    public interface ICreateShortUrlResponse
    {
        public string Id { get; set; }
        public int ShortUrl { get; set; }
    }
}
