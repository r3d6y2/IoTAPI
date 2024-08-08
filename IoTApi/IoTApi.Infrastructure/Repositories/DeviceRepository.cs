using System.Collections.Generic;
using System.Threading.Tasks;
using IoTApi.Domain.Entities;
using IoTApi.Domain.Interfaces;
using IoTApi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IoTApi.Infrastructure.Repositories;

public class DeviceRepository : IDeviceRepository
{
    private readonly IoTDbContext _context;

    public DeviceRepository(IoTDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Device>> GetAll()
    {
        return await _context.Devices.ToListAsync();
    }

    public async Task<Device> Get(long id)
    {
        return await _context
            .Devices
            .FirstAsync(d => d.Id == id);
    }

    public async Task<Device> Get(string deviceId)
    {
        return await _context
            .Devices
            .FirstAsync(d => d.DeviceId == deviceId);
    }

    public async Task<Device> Create(Device device)
    {
        _context.Devices.Add(device);
        
        await _context.SaveChangesAsync();

        return device;
    }

    public async Task<Device> Update(Device device)
    {
        _context.Entry(device).State = EntityState.Modified;

        await _context.SaveChangesAsync();

        return device;
    }

    public async Task Delete(long id)
    {
        var device = await Get(id);
        
        _context.Devices.Remove(device);

        await _context.SaveChangesAsync();
    }

    public async Task Delete(string deviceId)
    {
        var device = await Get(deviceId);
        
        _context.Devices.Remove(device);

        await _context.SaveChangesAsync();
    }
}