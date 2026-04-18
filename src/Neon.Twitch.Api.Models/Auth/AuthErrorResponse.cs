using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class AuthErrorResponse
{
    [JsonPropertyName("error")]
    public string? Error { get; set; }
    [JsonPropertyName("status")]
    public int? Status { get; set; }
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}