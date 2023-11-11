using Application.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Persistance.Configuration;
using Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddConfigurationApplicationLayer();
builder.Services.AddConfigurationRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors("AllowAnyOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();