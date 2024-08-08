using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IoTApi.Core.Interfaces;
using IoTApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IoTApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
    private readonly IDeviceService _deviceService;
    
    public DeviceController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
    }
    
    [HttpGet]
    public async Task<IEnumerable<DeviceRequestModel>> Get()
    {
        var devices = await _deviceService.GetAll();
        
        return devices.Select(d => new DeviceRequestModel
        {
            DeviceId = d.DeviceId,
            IsActive = d.IsActive,
            Name = d.Name
        });
    }

    [HttpPost]
    public async Task<DeviceRequestModel> RegisterDevice([FromBody] DeviceRequestModel deviceRequestModel)
    {
        return null;
    }
}