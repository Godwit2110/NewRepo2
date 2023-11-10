using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Entities
{
    public class Url
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string? Urls { get; set; }
        [Required]
        public string? ShortUrls { get; set; }
        [Required]
        public string? ContadorViews { get; set; }
        [Required]
        public CategoriaEnum Categorias { get; set; }
    }
}
