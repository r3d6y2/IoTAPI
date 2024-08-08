using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using IoTApi.Core.Dtos;
using IoTApi.Core.Interfaces;

namespace IoTApi.Core.Services;

public class DeviceService : IDeviceService
{
    public Task<DeviceDto> Create(DeviceDto device)
    {
        throw new NotImplementedException();
    }

    public Task<DeviceDto> Update(DeviceDto device)
    {
        throw new NotImplementedException();
    }

    public Task Delete(string deviceId)
    {
        throw new NotImplementedException();
    }

    public Task Delete(long id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<DeviceDto>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<DeviceDto> Get(string deviceId)
    {
        throw new NotImplementedException();
    }

    public Task<DeviceDto> Get(long id)
    {
        throw new NotImplementedException();
    }
}