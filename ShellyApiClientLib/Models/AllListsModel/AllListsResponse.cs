using System.Text.Json.Serialization;
using ShellyApiClientLib.Models.AllListsModel.DashboardModels;
using ShellyApiClientLib.Models.AllListsModel.DeviceModels;
using ShellyApiClientLib.Models.AllListsModel.GroupModels;
using ShellyApiClientLib.Models.AllListsModel.RoomModels;

namespace ShellyApiClientLib.Models.AllListsModel;

public class AllListsResponse
{
    [JsonPropertyName("devices")]
    public Dictionary<string, DeviceModel>? Devices { get; set; }
    
    [JsonPropertyName("rooms")]
    public Dictionary<string, RoomModel>? Rooms { get; set; }
    
    [JsonPropertyName("groups")]
    public Dictionary<string, GroupModel>? Groups { get; set; }
    
    [JsonPropertyName("dashboards")]
    public Dictionary<string, DashboardModel>? Dashboards { get; set; }
}