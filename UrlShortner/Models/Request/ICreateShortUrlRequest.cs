namespace UrlShortner.Models
{
    public interface ICreateShortUrlRequest
    {
        public string OriginalUrl { get; }
    }
}
