using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls;

public class Poll
{
    /// <summary>
    /// <para>An ID that identifies the poll.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>An ID that identifies the broadcaster that created the poll.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; init; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; init; }
    /// <summary>
    /// <para>The question that viewers are voting on. For example, What game should I play next? The title may contain a maximum of 60 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>A list of choices that viewers can choose from. The list will contain a minimum of two choices and up to a maximum of five choices.</para>
    /// </summary>
    [JsonPropertyName("choices")]
    public List<PollChoice>? Choices { get; init; }
    /// <summary>
    /// <para>Not used; will be set to false.</para>
    /// </summary>
    [JsonPropertyName("bits_voting_enabled")]
    public bool? BitsVotingEnabled { get; init; }
    /// <summary>
    /// <para>Not used; will be set to 0.</para>
    /// </summary>
    [JsonPropertyName("bits_per_vote")]
    public int? BitsPerVote { get; init; }
    /// <summary>
    /// <para>A Boolean value that indicates whether viewers may cast additional votes using Channel Points. For information about Channel Points, see <see href="https://help.twitch.tv/s/article/channel-points-guide">Channel Points Guide</see></para>
    /// </summary>
    [JsonPropertyName("channel_points_voting_enabled")]
    public bool? ChannelPointsVotingEnabled { get; init; }
    /// <summary>
    /// <para>The number of points the viewer must spend to cast one additional vote.</para>
    /// </summary>
    [JsonPropertyName("channel_points_per_vote")]
    public int? ChannelPointsPerVote { get; init; }
    /// <summary>
    /// <para>The poll’s status. Valid values are:</para>
    /// <para>ACTIVE — The poll is running.</para>
    /// <para>COMPLETED — The poll ended on schedule (see the duration field).</para>
    /// <para>TERMINATED — The poll was terminated before its scheduled end.</para>
    /// <para>ARCHIVED — The poll has been archived and is no longer visible on the channel.</para>
    /// <para>MODERATED — The poll was deleted.</para>
    /// <para>INVALID — Something went wrong while determining the state.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>The length of time (in seconds) that the poll will run for.</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the poll began.</para>
    /// </summary>
    [JsonPropertyName("started_at")]
    public string? StartedAt { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the poll ended. If status is ACTIVE, this field is set to null.</para>
    /// </summary>
    [JsonPropertyName("ended_at")]
    public string? EndedAt { get; init; }
}