using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

internal class Cheermote
{
    /// <summary>
    /// <para>The cheermote prefix.</para>
    /// </summary>
    [JsonPropertyName("prefix")]
    public string? Prefix { get; init; }
    /// <summary>
    /// <para>The number of bits cheered.</para>
    /// </summary>
    [JsonPropertyName("bits")]
    public int? Bits { get; init; }
    /// <summary>
    /// <para>The cheermote tier.</para>
    /// </summary>
    [JsonPropertyName("tier")]
    public int? Tier { get; init; }
}