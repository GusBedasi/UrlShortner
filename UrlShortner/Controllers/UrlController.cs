using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using UrlShortner.Models;

namespace UrlShortner.Controllers
{
    public class UrlController : ApiController
    {
        [Route("/url"), HttpPost]
        public IHttpActionResult ShortShortenUrl(ICreateShortUrlRequest request)
        {
            return Ok();
        }
    }
}
