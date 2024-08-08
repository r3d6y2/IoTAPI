using IoTApi.Domain.Interfaces;
using IoTApi.Infrastructure.Data;
using IoTApi.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoTApi.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        // Register the DbContext with SQL Server provider
        services.AddDbContext<IoTDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        // Register repositories
        services.AddScoped<IDeviceRepository, DeviceRepository>();

        return services;
    }
}