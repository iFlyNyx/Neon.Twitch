using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class ClientCredentialAuthResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; set; }
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }
}