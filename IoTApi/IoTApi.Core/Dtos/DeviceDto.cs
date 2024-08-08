namespace IoTApi.Core.Dtos;

public class DeviceDto
{
    public long Id { get; set; }
    
    public string DeviceId { get; set; }
    
    public string Name { get; set; }
    
    public bool IsActive { get; set; }
}