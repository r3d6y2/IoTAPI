using System.Collections.Generic;
using System.Threading.Tasks;
using IoTApi.Core.Dtos;

namespace IoTApi.Core.Interfaces;

public interface IDeviceService
{
    Task<DeviceDto> Create(DeviceDto device);

    Task<DeviceDto> Update(DeviceDto device);

    Task Delete(string deviceId);
    
    Task Delete(long id);
    
    Task<IEnumerable<DeviceDto>> GetAll();

    Task<DeviceDto> Get(string deviceId);

    Task<DeviceDto> Get(long id);
}