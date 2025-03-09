using LocoParser.Core.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LocoParser.Core.Infrastructure.Extensions;

public static class ServiceCollectionExtensons
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            string connectionString = configuration.GetConnectionString("PostgresConnection");
            options.UseNpgsql(connectionString);
        });
        
        return services;
    }
}