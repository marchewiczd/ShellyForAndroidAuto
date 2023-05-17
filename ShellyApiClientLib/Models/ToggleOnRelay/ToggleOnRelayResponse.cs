using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models.ToggleOnRelay;

public class ToggleOnRelayResponse
{
    [JsonPropertyName("device_id")]
    public string? DeviceId { get; set; }
}