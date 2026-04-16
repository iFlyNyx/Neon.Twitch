using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class ExtensionLiveChannel
{
    /// <summary>
    /// <para>The ID of the broadcaster that is streaming live and has installed or activated the extension.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; set; }
    /// <summary>
    /// <para>The name of the category or game being streamed.</para>
    /// </summary>
    [JsonPropertyName("game_name")]
    public string? GameName { get; set; }
    /// <summary>
    /// <para>The ID of the category or game being streamed.</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; set; }
    /// <summary>
    /// <para>The title of the broadcaster’s stream. May be an empty string if not specified.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}