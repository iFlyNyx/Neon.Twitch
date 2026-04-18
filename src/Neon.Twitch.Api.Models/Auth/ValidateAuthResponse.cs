using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class ValidateAuthResponse
{
    [JsonPropertyName("client_id")]
    public string? ClientId { get; init; }
    [JsonPropertyName("login")]
    public string? Login { get; init; }
    [JsonPropertyName("scopes")]
    public List<string>? Scopes { get; init; }
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; init; }
}