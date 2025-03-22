using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Quanto.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddPersistence(configuration);

        return services;
    }

    public static IServiceCollection AddPersistence(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        return services;
    }
}
