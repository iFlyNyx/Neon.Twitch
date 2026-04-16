using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain;

public class HypeTrainStatus
{
    /// <summary>
    /// <para>An object describing the current Hype Train. Null if a Hype Train is not active.</para>
    /// </summary>
    [JsonPropertyName("current")]
    public HypeTrainCurrent? Current { get; set; }
    /// <summary>
    /// <para>An object with information about the channel’s Hype Train records. Null if a Hype Train has not occurred.</para>
    /// </summary>
    [JsonPropertyName("all_time_high")]
    public HypeTrainRecord? AllTimeHigh { get; set; }
    /// <summary>
    /// <para>An object with information about the channel’s shared Hype Train records. Null if a Hype Train has not occurred.</para>
    /// </summary>
    [JsonPropertyName("shared_all_time_high")]
    public HypeTrainRecord? SharedAllTimeHigh { get; set; }
}