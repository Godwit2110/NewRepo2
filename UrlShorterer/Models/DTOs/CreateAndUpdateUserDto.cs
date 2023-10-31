using UrlShorterer.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace UrlShorterer.Models
{
    public class CreateAndUpdateUserDto
    {
        /*NOTA IMPORTANTE*/
        /*Los DTOS están en ESPAÑOL porque el front tiene las intefaces
         definidas en ESPAÑOL, esta es una de las ventajas de utilizar DTOs
        para transportar datos desde el back a una capa del front ya que nos permite adaptarnos
        y tener flexibilidad a la hora de responder a las requests*/
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contrasenia { get; set; }
        public string NombreDeUsuario { get; set; }
    }
}