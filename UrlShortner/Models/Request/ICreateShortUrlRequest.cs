namespace UrlShortner.Models
{
    public interface ICreateShortUrlRequest
    {
        public string UserId { get; }
        public string OriginalUrl { get; }
    }
}
