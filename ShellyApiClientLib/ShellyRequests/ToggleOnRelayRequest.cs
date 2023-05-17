namespace ShellyApiClientLib.ShellyRequests;

public class ToggleOnRelayRequest : ShellyRequestBase
{
    public ToggleOnRelayRequest(string deviceId)
        : base(
            "device/relay/control",
            new()
            {
                { "id", deviceId },
                { "channel", "0" },
                { "turn", "on" }
            })
    {
    }
}