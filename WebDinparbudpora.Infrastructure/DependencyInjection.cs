using System.Data.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebDinparbudpora.Application.Common.Interfaces;
using WebDinparbudpora.Infrastructure.Persistance;

namespace WebDinparbudpora.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure( 
        this IServiceCollection services, 
        IConfiguration configuration)
    {
        services.AddScoped<IUserRepository,UserRepository>();
        services.AddSingleton <DbConnectionFactory>();
        return services;
    }
}