using System.ComponentModel.DataAnnotations;

namespace UrlShorterer.Models
{
    public class AuthenticationRequestBody
    {
        [Required]
        public string? NombreDeUsuario { get; set; }
        [Required]
        public string? Contrasenia { get; set; }
    }
}
