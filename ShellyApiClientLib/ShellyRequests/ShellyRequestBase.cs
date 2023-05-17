namespace ShellyApiClientLib.ShellyRequests;

public abstract class ShellyRequestBase
{
    public ShellyRequestBase(string resource, Dictionary<string,string> parameters)
    {
        Resource = resource;
        Parameters = parameters;
    }
    
    public string Resource { get; }
    public Dictionary<string,string> Parameters { get; }
}