using MassTransit;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AmazonScraper.Service.Host.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static WebApplicationBuilder ConfigureAmazonService(this WebApplicationBuilder builder)
   {
          // Add controllers
    builder.Services.AddControllers();

 // Configure OpenAPI/Swagger
    builder.Services.AddEndpointsApiExplorer();
     builder.Services.AddSwaggerGen(options =>
          {
    options.SwaggerDoc("v1", new() { Title = "Amazon Scraper Service API", Version = "v1" });
            });

        // Add MassTransit
            builder.Services.AddMassTransit(x =>
      {
      x.UsingRabbitMq((context, cfg) =>
            {
          cfg.Host(builder.Configuration.GetConnectionString("Messaging"));
                });
   });

   // Add Application Services
       builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        builder.Services.AddApplicationInsightsTelemetry();

      return builder;
        }
    }
}