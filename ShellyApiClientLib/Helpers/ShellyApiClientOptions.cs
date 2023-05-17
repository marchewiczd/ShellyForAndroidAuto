namespace ShellyApiClientLib.Helpers;

public class ShellyApiClientOptions
{
    public bool ThrowIfNotSuccess { get; init; } = true;

    /// <summary>
    /// Minimum delay in milliseconds between requests. Default = 1500.
    /// </summary>
    public int MinDelayBetweenRequestsMs { get; init; } = 1500;
}