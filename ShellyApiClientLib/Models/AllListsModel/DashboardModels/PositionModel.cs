using System.Text.Json.Serialization;

namespace ShellyApiClientLib.Models.AllListsModel.DashboardModels;

public class PositionModel
{
    [JsonPropertyName("position")]
    public int Position { get; set; }
}