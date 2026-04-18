using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints;

public class MaxPerStreamSetting
{
    /// <summary>
    /// <para>A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per live stream. Is true if the reward applies a limit.</para>
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
    /// <summary>
    /// <para>The maximum number of redemptions allowed per live stream.</para>
    /// </summary>
    [JsonPropertyName("max_per_stream")]
    public long? MaxPerStream { get; init; } 
}