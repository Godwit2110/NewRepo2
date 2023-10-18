using UrlShorterer.Models;

namespace UrlShorterer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();


            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.MapPost("api/shorten", (XYZForCreationDto request) =>
            {
                if (Uri.TryCreate(request.Url, UriKind.Absolute, out _))
                {
                    return Results.BadRequest("El Url es invalido");
                }


            });

            app.UseHttpsRedirection();

            app.Run();
        }
    }
}