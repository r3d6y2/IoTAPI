using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using IoTApi.Core.Dtos;
using IoTApi.Core.Interfaces;
using IoTApi.Domain.Entities;
using IoTApi.Domain.Interfaces;

namespace IoTApi.Core.Services;

public class DeviceService : IDeviceService
{
    private readonly IDeviceRepository _deviceRepository;
    private readonly IMapper _mapper;

    public DeviceService(IDeviceRepository deviceRepository, IMapper mapper)
    {
        _deviceRepository = deviceRepository;
        _mapper = mapper;
    }
    
    public async Task<DeviceDto> Create(DeviceDto device)
    {
        var deviceEntity = _mapper.Map<Device>(device);

        var createdDevice = await _deviceRepository.Create(deviceEntity);

        return _mapper.Map<DeviceDto>(createdDevice);
    }

    public async Task<DeviceDto> Update(DeviceDto device)
    {
        var deviceEntity = _mapper.Map<Device>(device);

        var updatedDevice = await _deviceRepository.Update(deviceEntity);

        return _mapper.Map<DeviceDto>(updatedDevice);
    }

    public async Task Delete(string deviceId)
    {
        await _deviceRepository.Delete(deviceId);
    }

    public async Task Delete(long id)
    {
        await _deviceRepository.Delete(id);
    }

    public async Task<IEnumerable<DeviceDto>> GetAll()
    {
        var devices = await _deviceRepository.GetAll();

        return _mapper.Map<IEnumerable<DeviceDto>>(devices);
    }

    public async Task<DeviceDto> Get(string deviceId)
    {
        var device = await _deviceRepository.Get(deviceId);

        return _mapper.Map<DeviceDto>(device);
    }

    public async Task<DeviceDto> Get(long id)
    {
        var device = await _deviceRepository.Get(id);

        return _mapper.Map<DeviceDto>(device);
    }
}