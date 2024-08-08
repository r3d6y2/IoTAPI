using System.Collections.Generic;
using System.Threading.Tasks;
using IoTApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace IoTApi.Controllers;

[ApiController]
[Route("[controller]")]
public class DeviceController : ControllerBase
{
    public DeviceController()
    {
        
    }
    
    [HttpGet]
    public async Task<IEnumerable<DeviceRequestModel>> Get()
    {
        return null;
    }

    [HttpPost]
    public async Task<DeviceRequestModel> RegisterDevice([FromBody] DeviceRequestModel deviceRequestModel)
    {
        return null;
    }
}