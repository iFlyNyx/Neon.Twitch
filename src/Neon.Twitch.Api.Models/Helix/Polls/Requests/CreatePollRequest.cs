using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls.Requests;

public class CreatePollRequest
{
    /// <summary>
    /// <para>The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    [Required]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The question that viewers will vote on. For example, What game should I play next? The question may contain a maximum of 60 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    [Required]
    public string? Title { get; set; }
    /// <summary>
    /// <para>A list of choices that viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 5 choices.</para>
    /// </summary>
    [JsonPropertyName("choices")]
    [Required]
    [MinLength(2)]
    [MaxLength(5)]
    public List<CreatePollChoiceRequest>? Choices { get; set; }
    /// <summary>
    /// <para>The length of time (in seconds) that the poll will run for. The minimum is 15 seconds and the maximum is 1800 seconds (30 minutes).</para>
    /// </summary>
    [JsonPropertyName("duration")]
    [Required]
    public int? Duration { get; set; }
    /// <summary>
    /// <para>A Boolean value that indicates whether viewers may cast additional votes using Channel Points. If true, the viewer may cast more than one vote but each additional vote costs the number of Channel Points specified in channel_points_per_vote. The default is false (viewers may cast only one vote). For information about Channel Points, see <see href="https://help.twitch.tv/s/article/channel-points-guide">Channel Points Guide</see>.</para>
    /// </summary>
    [JsonPropertyName("channel_points_voting_enabled")]
    public bool? ChannelPointsVotingEnabled { get; set; }
    /// <summary>
    /// <para>The number of points that the viewer must spend to cast one additional vote. The minimum is 1 and the maximum is 1000000. Set only if ChannelPointsVotingEnabled is true.</para>
    /// </summary>
    [JsonPropertyName("channel_points_per_vote")]
    public int? ChannelPointsPerVote { get; set; }
}