using Microsoft.AspNetCore.Mvc;
using UrlShorterer.Data;
using UrlShorterer.Entities;
using UrlShorterer.Helpers;
using UrlShorterer.Models;

namespace UrlShorterer.Controllers
{
    [ApiController]
    [Route(template: "api/[controller]")]
    public class UrlController : Controller
    {
        private readonly UrlShortenerContext _UrlContext;

        public UrlController(UrlShortenerContext UrlContext)
        {
            _UrlContext = UrlContext;
        }

        [HttpGet("get")]

        public IActionResult GetUrl(string ClientUrl)
        {
            var urlEntity = _UrlContext.UserUrl.FirstOrDefault(x => x.ShortUrl == ClientUrl);

            if (urlEntity == null)
            {
                return NotFound("La URL no existe");
            }
            urlEntity.ContadorViews += 1;
            _UrlContext.SaveChanges();
            return Ok(urlEntity.Url);
            //return Redirect(urlEntity.Url);
        }

        [HttpPost("post")]
        public IActionResult CreateNewURL(string newurl)
        {
            var urlHelper = new UrlHelper();
            var urlEntity = new XYZForCreationDto()
            {
                Url = newurl,
                ShortUrl = urlHelper.GetShortURL()
            };
            _UrlContext.UserUrl.Add(urlEntity);
            _UrlContext.SaveChanges();
            return Ok(urlEntity.ShortUrl);
        }

    }
}