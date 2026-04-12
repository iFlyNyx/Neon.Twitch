using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits;

public class BitLeaderboardUser
{
    /// <summary>
    /// <para>An ID that identifies a user on the leaderboard.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; set; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
    /// <summary>
    /// <para>The user’s position on the leaderboard.</para>
    /// </summary>
    [JsonPropertyName("rank")]
    public int? Rank { get; set; }
    /// <summary>
    /// <para>The number of Bits the user has cheered.</para>
    /// </summary>
    [JsonPropertyName("score")]
    public int? Score { get; set; }
}