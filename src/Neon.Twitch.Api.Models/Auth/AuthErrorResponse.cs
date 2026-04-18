using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class AuthErrorResponse
{
    [JsonPropertyName("error")]
    public string? Error { get; init; }
    [JsonPropertyName("status")]
    public int? Status { get; init; }
    [JsonPropertyName("message")]
    public string? Message { get; init; }
}