using IoTApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IoTApi.Infrastructure.Data;

// IoTApi>dotnet ef migrations add InitialCreate -p IoTApi.Infrastructure -s IoTApi
// dotnet ef database update -p IoTApi.Infrastructure -s IoTApi
public class IoTDbContext(DbContextOptions<IoTDbContext> options) : DbContext(options)
{
    public DbSet<Device> Devices { get; set; }
}