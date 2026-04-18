using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class ModeratedChannel
{
    /// <summary>
    /// <para>An ID that uniquely identifies the channel this user can moderate.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The channel’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; set; }
    /// <summary>
    /// <para>The channels’ display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; set; }
}