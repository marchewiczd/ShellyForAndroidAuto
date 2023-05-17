namespace ShellyApiClientLib.Exceptions;

public class HttpResponseException : Exception
{
    public HttpResponseException() 
    { }
    
    public HttpResponseException(string message) : base(message) { }

    public HttpResponseException(string message, string? responseJson) : base(message)
    {
        ResponseJson = responseJson;
    }
    
    public string? ResponseJson { get; }
}