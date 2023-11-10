using UrlShorterer.Models;
using UrlShorterer.Entities;
using UrlShorterer.Services.Interfaces;
using UrlShortener.Data;

namespace Url_Shortener.Services.Implementations
{
    public class UserService : IUserService
    {
        private UrlShortenerContext _context;
        public UserService(UrlShortenerContext context)
        {
            _context = context;
        }

        public User? ValidateUser(AuthenticationRequestBody authRequestBody)
        {
            return _context.Users.FirstOrDefault(p => p.Email == authRequestBody.Email && p.Contrasenia == authRequestBody.Contrasenia);
        }

        public void Create(UserForCreationDto dto)
        {
            User newUser = new User()
            {
                Nombre = dto.Nombre,
                Email = dto.Email,
                Contrasenia = dto.Contrasenia
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
        }


    }
}