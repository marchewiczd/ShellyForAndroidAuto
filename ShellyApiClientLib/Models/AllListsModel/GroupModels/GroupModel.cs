using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models.AllListsModel.GroupModels;

public class GroupModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("image")]
    public string? ImagePath { get; set; }
    
    [JsonPropertyName("room_id")]
    public int RoomId { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    [JsonPropertyName("position")]
    public int Position { get; set; }
    
    [JsonPropertyName("devices")]
    public IEnumerable<string>? Devices { get; set; }
    
    [JsonPropertyName("modified")]
    public int LastModified { get; set; }
}