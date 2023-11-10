using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UrlShortener.Data;
using UrlShorterer.Entities;
using UrlShorterer.Helpers;
using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UrlController : ControllerBase
    {
        private readonly UrlShortenerContext _UrlContext;

        public UrlController(UrlShortenerContext UrlContext)
        {
            _UrlContext = UrlContext;
        }

        [HttpGet("Get")]

        public IActionResult GetUrl(string ClientUrl)
        {
            var urlEntity = _UrlContext.Urls.FirstOrDefault(x => x.ShortUrls == ClientUrl);

            if (urlEntity == null)
            {
                return NotFound("La URL no existe");
            }
            urlEntity.ContadorViews += 1;
            _UrlContext.SaveChanges();
            return Ok(urlEntity.Urls);
        }

        [HttpGet("GetByCategorias")]

        public IActionResult GetUrlsByCategory(CategoriaEnum Category)
        {
            var urlsFounded = _UrlContext.Urls.Where(x => x.Categorias == Category).ToList();

            var urlList = urlsFounded.Select(url => url.Urls).ToList();
            return Ok(urlList);
        }


        [HttpPost("Post")]
        public IActionResult CreateNewURL(string newurl, CategoriaEnum category)
        {
            var urlHelper = new UrlHelper();
            var urlEntity = new Url()
            {
                Urls = newurl,
                ShortUrls = urlHelper.GetShortURL(),
                Categorias = category
            };

            _UrlContext.Urls.Add(urlEntity);
            _UrlContext.SaveChanges();
            return Ok(urlEntity.ShortUrls);
        }


    }
}