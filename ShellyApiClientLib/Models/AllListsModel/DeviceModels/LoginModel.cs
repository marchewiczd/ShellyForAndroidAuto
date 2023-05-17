using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models.AllListsModel.DeviceModels;

public class LoginModel
{
    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
    
    [JsonPropertyName("username")]
    public string? Username { get; set; }
    
    [JsonPropertyName("password")]
    public string? Password { get; set; }
}