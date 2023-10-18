using Microsoft.EntityFrameworkCore;
using UrlShorterer.Data.Services;
using UrlShorterer.Entities;

namespace UrlShorterer.Data
{
    public class UrlShortenerContext : DbContext
    {
        public UrlShortenerContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<ShortenedUrl> ShortenedUrl { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShortenedUrl>(builder =>
            {
                builder.Property(s => s.Code).HasMAxLenght(XYZService.NumberOfCharsInShortLink);
                builder.HasIndex(s => s.Code).IsUnique();
            });
        }
    }
}
