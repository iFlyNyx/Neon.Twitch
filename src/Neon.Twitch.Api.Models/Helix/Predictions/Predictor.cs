using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class Predictor
{
    /// <summary>
    /// <para>An ID that identifies the viewer.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The viewer’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The viewer’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The number of Channel Points the viewer spent.</para>
    /// </summary>
    [JsonPropertyName("channel_points_used")]
    public int? ChannelPointsUsed { get; init; }
    /// <summary>
    /// <para>The number of Channel Points distributed to the viewer.</para>
    /// </summary>
    [JsonPropertyName("channel_points_won")]
    public int? ChannelPointsWon { get; init; }
}