using AmazonScraper.Service.Host.WebApi.Extensions;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.ConfigureAmazonService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Amazon Scraper Service API V1");
    });
}

if (app.Environment.IsProduction())
    app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Map("/", () => Results.Ok());
app.Map("/api/live", () => Results.Ok());

app.Run();