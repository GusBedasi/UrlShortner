using MongoDB.Driver;
using System;
using System.Text;
using UrlShortner.Database;
using UrlShortner.Models;
using UrlShortner.Models.Entities;
using UrlShortner.Seedwork;

namespace UrlShortner.Services
{
    public class UrlService : IUrlService
    {
        private readonly IMongoCollection<Url> _urls;
        public UrlService(IDbClient dbClient)
        {
            _urls = dbClient.GetUrlCollection();
        }

        public ICreateShortUrlResponse GenerateShortUrl(ICreateShortUrlRequest request)
        {
            var shortedUrlHash = Code.Create("", 7, true, false, false);

            var shortedUrlObj = new Url
            {
                UrlExternalId = Code.Create("url_"),
                ShortUrl = $"www.shortenurl.com/{shortedUrlHash}",
                Hash = shortedUrlHash,
                OriginalUrl = request.OriginalUrl,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };

            
            _urls.InsertOne(shortedUrlObj);
                
            return new CreateShortUrlResponse
            {
                ExternalId = shortedUrlObj.UrlExternalId,
                ShortUrl = shortedUrlObj.ShortUrl,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }
    }
}
