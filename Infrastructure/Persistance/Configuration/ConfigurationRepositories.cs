using Application.Models.EssayModels.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Repositories;

namespace Persistance.Configuration;

public static class ConfigurationRepositories
{
    public static IServiceCollection AddConfigurationRepositories(this IServiceCollection services)
    {
        services.AddScoped<IEssayRepository, EssayRepository>();

        return services;
    }
}