using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

public class Reward
{
    /// <summary>
    /// <para>The ID that uniquely identifies the redeemed reward.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The reward’s title.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>prompt displayed to the viewer </para>
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; init; }
    /// <summary>
    /// <para>The reward’s cost, in Channel Points.</para>
    /// </summary>
    [JsonPropertyName("cost")]
    public long? Cost  { get; init; }
}