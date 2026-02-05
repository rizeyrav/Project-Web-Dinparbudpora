using System.Data.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebDinparbudpora.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure( 
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddSingleton <DbConnectionFactory>();
        return services;
    }
}