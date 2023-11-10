using System.ComponentModel.DataAnnotations;
using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Models
{
    public class UrlForCreationDto
    {
        [Required] 
        public string Id {  get; set; }
        [Required]
        public string? Urls { get; set; }
        [Required]
        public string? ShortUrls { get; set; }
        public int ContadorViews { get; set; }
        public CategoriaEnum Categorias { get; set; }
    }
}
