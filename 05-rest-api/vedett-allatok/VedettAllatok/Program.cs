using VedettAllatok.Models;
using FastEndpoints;
using FastEndpoints.Swagger;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AnimalStore>();

builder.Services.AddOpenApi();
builder.Services.AddFastEndpoints().SwaggerDocument();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseFastEndpoints(c =>
{
    c.Endpoints.RoutePrefix = "api";
}).UseSwaggerGen();

app.UseHttpsRedirection();

app.Run();