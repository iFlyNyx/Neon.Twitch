using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class AddedSuspiciousStatusUserResponse
{
    /// <summary>
    /// <para>An array with one object containing information about the suspicious user action.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SuspiciousStatusUser>? Data { get; init; }
}