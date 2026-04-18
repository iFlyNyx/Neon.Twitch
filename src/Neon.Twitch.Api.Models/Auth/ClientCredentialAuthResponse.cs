using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class ClientCredentialAuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; init; }
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; init; }
    [JsonPropertyName("token_type")]
    public string? TokenType { get; init; }
}