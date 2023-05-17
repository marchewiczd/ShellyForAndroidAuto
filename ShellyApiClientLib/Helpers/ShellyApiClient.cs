using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using ShellyApiClientLib.Models;
using ShellyApiClientLib.ShellyRequests;

namespace ShellyApiClientLib.Helpers;

public class ShellyApiClient
{
    private static SemaphoreSlim _semaphore = new(1,1);
    
    private string _url;
    private string _authToken;
    private HttpClient _httpClient;
    private ShellyApiClientOptions _options;

    public ShellyApiClient(Uri url, string authToken)
        : this(url.AbsoluteUri, authToken, new ShellyApiClientOptions())
    {
    }

    public ShellyApiClient(Uri url, string authToken, ShellyApiClientOptions options)
        : this(url.AbsoluteUri, authToken, options)
    {
    }
    
    public ShellyApiClient(string url, string authToken)
        : this(url, authToken, new ShellyApiClientOptions())
    {
    }
    
    public ShellyApiClient(string url, string authToken, ShellyApiClientOptions options)
    {
        _url = url;
        _authToken = authToken;
        _options = options;

        _httpClient = new();
        _httpClient.DefaultRequestHeaders.Accept.Clear();
        _httpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<HttpResponseMessage?> PostAsync(ShellyRequestBase request)
    {
        HttpResponseMessage? response;
        
        // API can't handle more than one request per 1.5-2 seconds
        // below is a solution to handle this problem
        await _semaphore.WaitAsync();
        try
        {
            response = await _httpClient.PostAsync(_url + request.Resource, GetRequestContent(request));
            await Task.Delay(_options.MinDelayBetweenRequestsMs);
        }
        finally
        {
            _semaphore.Release();
        }

        return response;
    }

    public async Task<T?> PostAsync<T>(ShellyRequestBase request)
    {
        var httpResponseMessage = await PostAsync(request);
        
        if (httpResponseMessage is null)
            throw new HttpRequestException($"Response is null");

        if (_options.ThrowIfNotSuccess 
            && httpResponseMessage.StatusCode != HttpStatusCode.Created
            && httpResponseMessage.StatusCode != HttpStatusCode.OK)
            throw new HttpRequestException($"Status code is {httpResponseMessage.StatusCode}");
        
        var jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();
        var responseObj = JsonSerializer.Deserialize<ResponseRoot<T>>(jsonResponse);
        
        if (responseObj is null || !responseObj.IsOk)
            throw new JsonException("Response is not valid");
        
        return responseObj.Data;
    }

    private FormUrlEncodedContent GetRequestContent(ShellyRequestBase request)
    {
        const string authTokenKeyName = "auth_key";
        request.Parameters.TryAdd(authTokenKeyName, _authToken);
        
        return new FormUrlEncodedContent(request.Parameters);
    }
}