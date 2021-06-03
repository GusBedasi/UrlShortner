using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortner.Models;

namespace UrlShortner.Services
{
    public interface IUrlService
    {
        public ICreateShortUrlResponse GenerateShortUrl(ICreateShortUrlRequest request);
    }
}
