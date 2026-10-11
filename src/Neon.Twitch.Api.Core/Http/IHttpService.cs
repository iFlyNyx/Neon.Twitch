using System.Net.Http.Headers;

namespace Neon.Twitch.Api.Core.Http;

public interface IHttpService
{
    Task<HttpResponseMessage?> GetAsync(string? url, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default);
    Task<HttpResponseMessage?> PostAsync(string? url, HttpContent? content, string? contentType,
        AuthenticationHeaderValue? authHeader, Dictionary<string, string>? headers, CancellationToken ct = default);
    Task<HttpResponseMessage?> PutAsync(string? url, HttpContent? content, string? contentType,
        AuthenticationHeaderValue? authHeader, Dictionary<string, string>? headers, CancellationToken ct = default);
    Task<HttpResponseMessage?> PatchAsync(string? url, HttpContent? content, string? contentType,
        AuthenticationHeaderValue? authHeader, Dictionary<string, string>? headers, CancellationToken ct = default);
    Task<HttpResponseMessage?> DeleteAsync(string? url, AuthenticationHeaderValue? authHeader,
        Dictionary<string, string>? headers, CancellationToken ct = default);
}