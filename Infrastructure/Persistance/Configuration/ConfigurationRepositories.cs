using Application.Models.EssayModels.Interfaces;
using Application.Profiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories;

namespace Persistance.Configuration;

public static class ConfigurationRepositories
{
    public static IServiceCollection AddConfigurationRepositories(this IServiceCollection services)
    {
        
        services.AddAutoMapper(typeof(EssayProfile).Assembly);
        services.AddScoped<IEssayRepository, EssayRepository>();
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            
            options.UseSqlServer("Server=.;Database=Philosophy;Integrated Security=True;Encrypt=False;");
        });
        return services;
    }
}