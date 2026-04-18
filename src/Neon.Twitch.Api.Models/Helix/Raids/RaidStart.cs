using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Raids;

public class RaidStart
{
    /// <summary>
    /// <para>The UTC date and time, in RFC3339 format, of when the raid was requested.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
    /// <summary>
    /// <para>A Boolean value that indicates whether the channel being raided contains mature content.</para>
    /// </summary>
    [JsonPropertyName("is_mature")]
    [Obsolete("This field is deprecated and returns only false")]
    public bool? IsMature { get; init; }
}