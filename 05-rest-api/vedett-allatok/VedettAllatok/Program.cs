using VedettAllatok.Models;
using FastEndpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<AnimalStore>();

builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();
builder.Services.AddFastEndpoints();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseFastEndpoints();

app.Run();