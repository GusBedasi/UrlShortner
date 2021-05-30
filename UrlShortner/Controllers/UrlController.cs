using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortner.Models;
using UrlShortner.Models.Request;
using UrlShortner.Services;

namespace UrlShortner.Controllers
{
    [ApiController]
    public class UrlController : ControllerBase
    {
        private readonly IUrlService _urlService;
        public UrlController(IUrlService urlService)
        {
            _urlService = urlService;
        }

        [Route("/url")]
        [HttpPost]
        public IActionResult ShortShortenUrl(CreateShortUrlRequest request)
        {
            request.UserId = Request.Headers["UserId"].ToString();
            var response = _urlService.GenerateShortUrl(request);
            return Ok(response);
        }
    }
}
