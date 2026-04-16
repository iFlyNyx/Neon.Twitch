using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain;

public class HypeTrainRecord
{
    /// <summary>
    /// <para>The level of the record Hype Train.</para>
    /// </summary>
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    /// <summary>
    /// <para>Total points contributed to the record Hype Train.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
    /// <summary>
    /// <para>The time when the record was achieved.</para>
    /// </summary>
    [JsonPropertyName("achieved_at")]
    public string? AchievedAt { get; set; }
}