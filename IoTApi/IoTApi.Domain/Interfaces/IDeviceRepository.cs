using System.Collections.Generic;
using System.Threading.Tasks;
using IoTApi.Domain.Entities;

namespace IoTApi.Domain.Interfaces;

public interface IDeviceRepository
{
    Task<IEnumerable<Device>> GetAll();

    Task<Device> Get(long id);

    Task<Device> Get(string deviceId);
    
    Task<Device> Create(Device device);

    Task<Device> Update(Device device);

    Task Delete(long id);

    Task Delete(string deviceId);
}