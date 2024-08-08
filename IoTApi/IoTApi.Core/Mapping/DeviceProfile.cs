using AutoMapper;
using IoTApi.Core.Dtos;
using IoTApi.Domain.Entities;

namespace IoTApi.Core.Mapping;

public class DeviceProfile : Profile
{
    public DeviceProfile()
    {
        CreateMap<Device, DeviceDto>().ReverseMap();
    }
}