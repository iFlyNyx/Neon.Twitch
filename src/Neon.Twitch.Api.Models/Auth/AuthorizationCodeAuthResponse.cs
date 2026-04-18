using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class AuthorizationCodeAuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }
    [JsonPropertyName("refresh_token")]
    public string? RefreshToken { get; set; }
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }
    [JsonPropertyName("scope")]
    public List<string>? Scopes { get; set; }
}