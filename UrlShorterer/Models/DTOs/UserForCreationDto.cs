using UrlShorterer.Models.DTOs;

namespace UrlShorterer.Models
{
    public class UserForCreationDto
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
    }
}