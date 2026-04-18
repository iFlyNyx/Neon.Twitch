using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class AuthorizationCodeAuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; init; }
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; init; }
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; init; }
    [JsonPropertyName("token_type")]
    public string? TokenType { get; init; }
    [JsonPropertyName("scope")]
    public List<string>? Scopes { get; init; }
}