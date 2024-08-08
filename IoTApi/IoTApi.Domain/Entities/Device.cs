namespace IoTApi.Domain.Entities;

public class Device
{
    public long Id { get; set; }
    
    public string DeviceId { get; set; }
    
    public string Name { get; set; }
    
    public bool IsActive { get; set; }
}