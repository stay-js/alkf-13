global using FluentValidation;

using FastEndpoints;
using FastEndpoints.Swagger;
using GyogyfurdokLib;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<BathsStore>();

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
});

app.UseSwaggerGen();

app.UseHttpsRedirection();

await app.RunAsync();
