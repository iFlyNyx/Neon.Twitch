using System.Dynamic;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Bits.Models;

internal class CustomPowerUp
{
    /// <summary>
    /// <para>The ID that uniquely identifies the broadcaster.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; init; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; init; }
    /// <summary>
    /// <para>The ID that uniquely identifies this custom Power-up.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The title of the custom Power-up.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>The prompt shown to the viewer when they redeem the custom Power-up if user input is required (see the is_user_input_required field).</para>
    /// </summary>
    [JsonPropertyName("prompt")]
    public string? Prompt { get; init; }
    /// <summary>
    /// <para>The amount of Bits for the custom Power-up.</para>
    /// </summary>
    [JsonPropertyName("bits")]
    public int? Bits { get; init; }
    /// <summary>
    /// <para>A set of custom images for the custom Power-up. This field is null if the broadcaster didn't upload images.</para>
    /// </summary>
    [JsonPropertyName("image")]
    public Image? Image { get; init; }
    /// <summary>
    /// <para>A set of default images for the custom Power-up.</para>
    /// </summary>
    [JsonPropertyName("default_image")]
    public Image? DefaultImage { get; init; }
    /// <summary>
    /// <para>The background color to use for the custom Power-up. The color is in Hex format (for example, #00E5CB).</para>
    /// </summary>
    [JsonPropertyName("background_color")]
    public string? BackgroundColor { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the custom Power-up is enabled. Is true if enabled; otherwise, false. Disabled custom Power-ups aren’t shown to the user.</para>
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the user must enter information when redeeming the custom Power-up. Is true if the user is prompted.</para>
    /// </summary>
    [JsonPropertyName("is_user_input_required")]
    public bool? IsUserInputRequired { get; init; }
    /// <summary>
    /// <para>The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.</para>
    /// </summary>
    [JsonPropertyName("max_per_stream_setting")]
    public MaxPerStreamSetting? MaxPerStreamSetting { get; init; }
    /// <summary>
    /// <para>The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.</para>
    /// </summary>
    [JsonPropertyName("max_per_user_per_stream_setting")]
    public MaxPerUserPerStreamSetting? MaxPerUserPerStreamSetting { get; init; }
    /// <summary>
    /// <para>The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.</para>
    /// </summary>
    [JsonPropertyName("global_cooldown_setting")]
    public GlobalCooldownSetting? GlobalCooldownSetting { get; init; }
    /// <summary>
    /// <para> A Boolean value that determines whether the custom Power-up is currently paused. Is true if the custom Power-up is paused. Viewers can’t redeem paused custom Power-ups. </para>
    /// </summary>
    [JsonPropertyName("is_paused")]
    public bool? IsPaused { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the custom Power-up is currently in stock. Is true if the custom Power-up is in stock. Viewers can’t redeem out of stock custom Power-ups.</para>
    /// </summary>
    [JsonPropertyName("is_in_stock")]
    public bool? IsInStock { get; init; }
    /// <summary>
    /// <para>The number of redemptions redeemed during the current live stream. The number counts against the max_per_stream_setting limit. This field is null if the broadcaster’s stream isn’t live or max_per_stream_setting isn’t enabled.</para>
    /// </summary>
    [JsonPropertyName("redemptions_redeemed_current_stream")]
    public int? RedemptionsRedeemedCurrentStream { get; init; }
    /// <summary>
    /// <para>The timestamp of when the cooldown period expires. Is null if the custom Power-up isn’t in a cooldown state. See the global_cooldown_setting field.</para>
    /// </summary>
    [JsonPropertyName("cooldown_expires_at")]
    public string? CooldownExpiresAt { get; init; } 
}