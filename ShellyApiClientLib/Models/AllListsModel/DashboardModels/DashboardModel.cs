using System.Text.Json.Serialization;
using ShellyApiClientLib.Converters;

namespace ShellyApiClientLib.Models.AllListsModel.DashboardModels;

public class DashboardModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("image")]
    public string? ImagePath { get; set; }
    
    [JsonPropertyName("position")]
    public int Position { get; set; }
    
    [JsonPropertyName("modified")]
    public int LastModified { get; set; }
    
    [JsonPropertyName("scenes")]
    [JsonConverter(typeof(EmptyArrayToDictionaryConverter))]
    public Dictionary<string, PositionModel>? Scenes { get; set; }
    
    [JsonPropertyName("groups")]
    [JsonConverter(typeof(EmptyArrayToDictionaryConverter))]
    public Dictionary<string, PositionModel>? Groups { get; set; }
    
    [JsonPropertyName("devices")]
    [JsonConverter(typeof(EmptyArrayToDictionaryConverter))]
    public Dictionary<string, PositionModel>? Devices { get; set; }
    
    [JsonPropertyName("rooms")]
    [JsonConverter(typeof(EmptyArrayToDictionaryConverter))]
    public Dictionary<string, PositionModel>? Rooms { get; set; }
    
}