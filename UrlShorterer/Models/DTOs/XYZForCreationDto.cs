using System.ComponentModel.DataAnnotations;

namespace UrlShorterer.Models
{
    public class XYZForCreationDto
    {
        [Required]
        public string Url { get; set; }

        [Required]
        public string ShortUrl { get; set; }

        public string Id {  get; set; }

        [Required]
        public int ContadorViews { get; set; }
    }
}
