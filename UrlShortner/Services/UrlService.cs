using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortner.Models;

namespace UrlShortner.Services
{
    public class UrlService : IUrlService
    {
        public string GenerateHash()
        {
            throw new NotImplementedException();
        }

        public ICreateShortUrlResponse GenerateShortUrl(ICreateShortUrlRequest request)
        {
            return new CreateShortUrlResponse
            {
                Id = request.UserId,
                ShortUrl = request.Url.GetHashCode()
            };
        }
    }
}
