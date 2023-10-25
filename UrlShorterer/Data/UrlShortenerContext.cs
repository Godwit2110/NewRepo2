using Microsoft.EntityFrameworkCore;
using UrlShorterer.Data.Services;
using UrlShorterer.Entities;
using UrlShorterer.Models;

namespace UrlShorterer.Data
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions<UrlShortenerContext> options) : base(options)
        {
        }

        public DbSet<XYZForCreationDto> UserUrl { get; set; }
    }

}


