using Application.Models.EssayModels.Interfaces;
using Application.Profiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories;

namespace Persistance.Configuration;

public static class ConfigurationRepositories
{
    public static IServiceCollection AddConfigurationRepositories(this IServiceCollection services)
    {
        var connectionString = GetConnectionString();

        services.AddAutoMapper(typeof(EssayProfile).Assembly);
        services.AddScoped<IEssayRepository, EssayRepository>();
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });
        return services;
    }

    private static string? GetConnectionString()
    {
        var currentDirectory = Directory.GetCurrentDirectory();

        var appsettingsPath = Path.Combine(currentDirectory,  "appsettings.json");

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(currentDirectory)
            .AddJsonFile(appsettingsPath, optional: false)
            .Build();
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        return connectionString;
    }
}