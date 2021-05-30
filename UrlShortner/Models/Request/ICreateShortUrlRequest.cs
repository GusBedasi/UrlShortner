namespace UrlShortner.Models
{
    public interface ICreateShortUrlRequest
    {
        public string UserId { get; }
        public string Url { get; }
    }
}
