using ShellyApiClientLib.Helpers;
using ShellyApiClientLib.Models.AllListsModel;
using ShellyApiClientLib.Models.ToggleOnRelay;
using ShellyApiClientLib.ShellyRequests;


var secretsPath = @"C:\temp\secrets";
var secrets = File.ReadAllLines(secretsPath);
var authToken = secrets[0];
var serverUrl = secrets[1];
var deviceId = secrets[2];

var apiClientOptions = new ShellyApiClientOptions
{
    ThrowIfNotSuccess = true,
    MinDelayBetweenRequestsMs = 1500
};

var apiClient = new ShellyApiClient(serverUrl, authToken, apiClientOptions);
    
var toggleOnRelayResponse = await apiClient.PostAsync<ToggleOnRelayResponse>(new ToggleOnRelayRequest(deviceId));
var allListsResponse = await apiClient.PostAsync<AllListsResponse>(new AllListsRequest());