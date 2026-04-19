using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class Secret
{
    /// <summary>
    /// <para>The raw secret that you use with JWT encoding.</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that you may begin using this secret to sign a JWT.</para>
    /// </summary>
    [JsonPropertyName("active_at")]
    public string? ActiveAt { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that you must stop using this secret to decode a JWT.</para>
    /// </summary>
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; init; }
}