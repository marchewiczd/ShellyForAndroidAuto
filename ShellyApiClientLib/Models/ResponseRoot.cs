using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models;

/// <summary>
/// Every response from Shelly Cloud has the same root.
/// This class represents this relation.
/// </summary>
/// <typeparam name="T">
/// Type of a response, i.e. ToggleOnRelayResponse 
/// </typeparam>
public class ResponseRoot<T>
{
    [JsonPropertyName("isok")]
    public bool IsOk { get; set; }
    
    [JsonPropertyName("data")]
    public T? Data { get; set; }
}