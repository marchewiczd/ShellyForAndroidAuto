namespace ShellyApiClientLib.ShellyRequests;

public class AllListsRequest : ShellyRequestBase
{
    public AllListsRequest()
        : base(
            "interface/device/get_all_lists",
            new())
    {
    }
}