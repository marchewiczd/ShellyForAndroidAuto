using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models.AllListsModel.DeviceModels;

public class DeviceModel
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("image")]
    public string? ImagePath { get; set; }
    
    [JsonPropertyName("category")]
    public string? Category { get; set; }
    
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    
    [JsonPropertyName("room_id")]
    public int RoomId { get; set; }
    
    [JsonPropertyName("channel")]
    public int ChannelId { get; set; }
    
    [JsonPropertyName("channels_count")]
    public int ChannelsCount { get; set; }
    
    [JsonPropertyName("exclude_event_log")]
    public bool ExcludeEventLog { get; set; }
    
    [JsonPropertyName("name_sync")]
    public bool NameSync { get; set; }
    
    [JsonPropertyName("gen")]
    public int Generation { get; set; }
    
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
    
    [JsonPropertyName("cloud")]
    public bool Cloud { get; set; }
    
    [JsonPropertyName("cloud_assoc")]
    public bool CloudAssociation { get; set; }
    
    [JsonPropertyName("template")]
    public string? Template { get; set; }
    
    [JsonPropertyName("position")]
    public int Position { get; set; }
    
    [JsonPropertyName("modified")]
    public int LastModified { get; set; }
    
    [JsonPropertyName("login")]
    public LoginModel? Login { get; set; }
}