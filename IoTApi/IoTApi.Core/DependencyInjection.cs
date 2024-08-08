using IoTApi.Core.Interfaces;
using IoTApi.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IoTApi.Core;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IDeviceService, DeviceService>();
        return services;
    }
}