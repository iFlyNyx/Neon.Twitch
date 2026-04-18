using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Schedule;

public class StreamSchedule
{
    /// <summary>
    /// <para>The list of broadcasts in the broadcaster’s streaming schedule.</para>
    /// </summary>
    [JsonPropertyName("segments")]
    public List<Segment>? Segments { get; set; }
    /// <summary>
    /// <para>The ID of the broadcaster that owns the broadcast schedule.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; set; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; set; }
    /// <summary>
    /// <para>The dates when the broadcaster is on vacation and not streaming. Is set to null if vacation mode is not enabled.</para>
    /// </summary>
    [JsonPropertyName("vacation")]
    public Vacation? Vacation { get; set; }
}