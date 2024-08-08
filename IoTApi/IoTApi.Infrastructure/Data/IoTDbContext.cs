using IoTApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IoTApi.Infrastructure.Data;

public class IoTDbContext(DbContextOptions<IoTDbContext> options) : DbContext(options)
{
    public DbSet<Device> Devices { get; set; }
}