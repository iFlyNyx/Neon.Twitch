using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Requests;

public abstract class CustomRewardRequest
{
    /// <summary>
    /// <para>The custom reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The cost of the reward, in Channel Points. The minimum is 1 point.</para>
    /// </summary>
    [JsonPropertyName("cost")]
    public long? Cost { get; set; }
    /// <summary>
    /// <para>The prompt shown to the viewer when they redeem the reward. Specify a prompt if is_user_input_required is true. The prompt is limited to a maximum of 200 characters.</para>
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the reward is enabled. Viewers see only enabled rewards. The default is true.</para>
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; set; }
    /// <summary>
    /// <para>The background color to use for the reward. Specify the color using Hex format (for example, #9147FF).</para>
    /// </summary>
    [JsonPropertyName("background_color")]
    public string? BackgroundColor { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the user needs to enter information when redeeming the reward. See the prompt field. The default is false.</para>
    /// </summary>
    [JsonPropertyName("is_user_input_required")]
    public bool? IsUserInputRequired { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the max_per_stream field). The default is false.</para>
    /// </summary>
    [JsonPropertyName("is_max_per_stream_enabled")]
    public bool? IsMaxPerStreamEnabled { get; set; }
    /// <summary>
    /// <para>The maximum number of redemptions allowed per live stream. Applied only if is_max_per_stream_enabled is true. The minimum value is 1.</para>
    /// </summary>
    [JsonPropertyName("max_per_stream")]
    public int? MaxPerStream { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see the max_per_user_per_stream field). The default is false.</para>
    /// </summary>
    [JsonPropertyName("is_max_per_user_per_stream_enabled")]
    public bool? IsMaxPerUserPerStreamEnabled { get; set; }
    /// <summary>
    /// <para>The maximum number of redemptions allowed per user per stream. Applied only if is_max_per_user_per_stream_enabled is true. The minimum value is 1.</para>
    /// </summary>
    [JsonPropertyName("max_per_user_per_stream")]
    public int? MaxPerUserPerStream { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether to apply a cooldown period between redemptions (see the global_cooldown_seconds field for the duration of the cooldown period). The default is false.</para>
    /// </summary>
    [JsonPropertyName("is_global_cooldown_enabled")]
    public bool? IsGlobalCooldownEnabled { get; set; }
    /// <summary>
    /// <para>The cooldown period, in seconds. Applied only if the is_global_cooldown_enabled field is true. The minimum value is 1; however, the minimum value is 60 for it to be shown in the Twitch UX.</para>
    /// </summary>
    [JsonPropertyName("global_cooldown_seconds")]
    public int? GlobalCooldownSeconds { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If false, status is set to UNFULFILLED and follows the normal request queue process. The default is false.</para>
    /// </summary>
    [JsonPropertyName("should_redemptions_skip_request_queue")]
    public bool? ShouldRedemptionsSkipRequestQueue { get; set; }
}