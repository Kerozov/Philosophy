using Application.Models.EssayModels.Interfaces;
using Application.Profiles;
using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Helpers;

public static class ConfigurationApplicationLayer
{
    public static IServiceCollection AddConfigurationApplicationLayer(this IServiceCollection services)
    {
        services.AddScoped<IEssayService, EssayService>();
        
        return services;

    }
}