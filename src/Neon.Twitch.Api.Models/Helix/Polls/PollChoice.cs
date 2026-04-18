using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls;

public class PollChoice
{
    /// <summary>
    /// <para>An ID that identifies this choice.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The choice’s title. The title may contain a maximum of 25 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The total number of votes cast for this choice.</para>
    /// </summary>
    [JsonPropertyName("votes")]
    public int? Votes { get; set; }
    /// <summary>
    /// <para>The number of votes cast using Channel Points.</para>
    /// </summary>
    [JsonPropertyName("channel_points_votes")]
    public int? ChannelPointsVotes { get; set; }
    /// <summary>
    /// <para>Not used; will be set to 0.</para>
    /// </summary>
    [JsonPropertyName("bits_votes")]
    public int? BitsVotes { get; set; }
}