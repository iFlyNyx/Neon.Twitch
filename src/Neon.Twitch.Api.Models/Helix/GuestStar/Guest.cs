using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class Guest
{
    /// <summary>
    /// <para>ID representing this guest’s slot assignment. </para>
    /// <para>Host is always in slot "0"</para>
    /// <para>Guests are assigned the following consecutive IDs (e.g, "1", "2", "3", etc)</para>
    /// <para>Screen Share is represented as a special guest with the ID "SCREENSHARE"</para>
    /// <para>The identifier here matches the ID referenced in browser source links used in broadcasting software.</para>
    /// </summary>
    [JsonPropertyName("slot_id")]
    public string? SlotId { get; init; }
    /// <summary>
    /// <para>Flag determining whether or not the guest is visible in the browser source in the host’s streaming software.</para>
    /// </summary>
    [JsonPropertyName("is_live")]
    public bool? IsLive { get; init; }
    /// <summary>
    /// <para>User ID of the guest assigned to this slot.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>Display name of the guest assigned to this slot.</para>
    /// </summary>
    [JsonPropertyName("user_display_name")]
    public string? UserDisplayName { get; init; }
    /// <summary>
    /// <para>Login of the guest assigned to this slot.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>Value from 0 to 100 representing the host’s volume setting for this guest.</para>
    /// </summary>
    [JsonPropertyName("volume")]
    public int? Volume { get; init; }
    /// <summary>
    /// <para>Timestamp when this guest was assigned a slot in the session.</para>
    /// </summary>
    [JsonPropertyName("assigned_at")]
    public string? AssignedAt { get; init; }
    /// <summary>
    /// <para>Information about the guest’s audio settings</para>
    /// </summary>
    [JsonPropertyName("audio_settings")]
    public MediaSetting? AudioSettings { get; init; }
    /// <summary>
    /// <para>Information about the guest’s video settings</para>
    /// </summary>
    [JsonPropertyName("video_settings")]
    public MediaSetting? VideoSettings { get; init; }
}