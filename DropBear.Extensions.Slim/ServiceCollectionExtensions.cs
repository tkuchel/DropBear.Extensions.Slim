using Microsoft.Extensions.DependencyInjection;

namespace DropBear.Extensions.Slim;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSlimExtension(this IServiceCollection services, Action<SlimOptions> configure)
    {
        services.Configure(configure);
        //services.AddSingleton<MenuManager>();
        //TODO: Add Slim services this is for future use, not part of initial release
        return services;
    }
}
