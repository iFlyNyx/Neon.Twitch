using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

public class GlobalCooldownSetting
{
    /// <summary>
    /// <para>A Boolean value that determines whether to apply a cooldown period. Is true if a cooldown period is enabled.</para>
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
    /// <summary>
    /// <para>The cooldown period, in seconds.</para>
    /// </summary>
    [JsonPropertyName("global_cooldown_seconds")]
    public long? GlobalCooldownSeconds { get; init; }
}