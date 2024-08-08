namespace IoTApi.Models;

public class DeviceRequestModel
{
    public string DeviceId { get; set; }
    
    public string Name { get; set; }
    
    public bool IsActive { get; set; }
}