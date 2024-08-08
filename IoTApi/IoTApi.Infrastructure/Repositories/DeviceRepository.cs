using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IoTApi.Domain.Entities;
using IoTApi.Domain.Interfaces;

namespace IoTApi.Infrastructure.Repositories;

public class DeviceRepository : IDeviceRepository
{
    public Task<IEnumerable<Device>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<Device> Get(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Device> Get(string deviceId)
    {
        throw new NotImplementedException();
    }

    public Task<Device> Create(Device device)
    {
        throw new NotImplementedException();
    }

    public Task<Device> Update(Device device)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long id)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string deviceId)
    {
        throw new NotImplementedException();
    }
}