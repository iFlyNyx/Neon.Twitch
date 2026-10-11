using System.Net.Http.Headers;

namespace Neon.Twitch.Api.Core.Http;

public class HttpService(IHttpClientFactory httpClientFactory) : IHttpService
{
    private static void ConfigureClient(HttpClient httpClient, HttpMethod? method, string? url, HttpContent? content,
        string? contentType, AuthenticationHeaderValue? authHeader, Dictionary<string, string>? headers)
    {
        ArgumentNullException.ThrowIfNull(method);
        ArgumentException.ThrowIfNullOrEmpty(url);

        if (method == HttpMethod.Post || method == HttpMethod.Put || method == HttpMethod.Patch)
        {
            ArgumentNullException.ThrowIfNull(content);
            ArgumentException.ThrowIfNullOrEmpty(contentType);
        }
        
        if (headers?.Count > 0)
            foreach (var key in headers.Keys)
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation(key, headers[key]);

        httpClient.DefaultRequestHeaders.Authorization = authHeader;
    }

    public async Task<HttpResponseMessage?> GetAsync(string? url, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default)
    {
        using var httpClient = httpClientFactory.CreateClient();
        ConfigureClient(httpClient, HttpMethod.Get, url, null, string.Empty, authHeader, headers);
        return await httpClient.GetAsync(new Uri(url!), ct);
    }
    
    public async Task<HttpResponseMessage?> PostAsync(string? url, HttpContent? content, string? contentType, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default)
    {
        using var httpClient = httpClientFactory.CreateClient();
        ConfigureClient(httpClient, HttpMethod.Post, url, content, contentType, authHeader, headers);
        return await httpClient.PostAsync(new Uri(url!), content, ct);
    }
    
    public async Task<HttpResponseMessage?> PutAsync(string? url, HttpContent? content, string? contentType, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default)
    {
        using var httpClient = httpClientFactory.CreateClient();
        ConfigureClient(httpClient, HttpMethod.Put, url, content, contentType, authHeader, headers);
        return await httpClient.PutAsync(new Uri(url!), content, ct);
    }
    
    public async Task<HttpResponseMessage?> PatchAsync(string? url, HttpContent? content, string? contentType, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default)
    {
        using var httpClient = httpClientFactory.CreateClient();
        ConfigureClient(httpClient, HttpMethod.Patch, url, content, contentType, authHeader, headers);
        return await httpClient.PatchAsync(new Uri(url!), content, ct);
    }
    
    public async Task<HttpResponseMessage?> DeleteAsync(string? url, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default)
    {
        using var httpClient = httpClientFactory.CreateClient();
        ConfigureClient(httpClient, HttpMethod.Delete, url, null, string.Empty, authHeader, headers);
        return await httpClient.DeleteAsync(new Uri(url!), ct);
    }
}