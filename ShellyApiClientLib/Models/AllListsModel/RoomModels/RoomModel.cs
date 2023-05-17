using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models.AllListsModel.RoomModels;

public class RoomModel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    
    [JsonPropertyName("image")]
    public string? ImagePath { get; set; }
    
    [JsonPropertyName("position")]
    public int Position { get; set; }
    
    [JsonPropertyName("overview_style")]
    public bool OverviewStyle { get; set; }
    
    [JsonPropertyName("floor")]
    public int Floor { get; set; }
    
    [JsonPropertyName("modified")]
    public int LastModified { get; set; }
}