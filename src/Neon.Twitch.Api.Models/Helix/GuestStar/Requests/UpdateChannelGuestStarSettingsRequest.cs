using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Requests;

public class UpdateChannelGuestStarSettingsRequest
{
    /// <summary>
    /// <para>Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.</para>
    /// </summary>
    [JsonPropertyName("is_moderator_send_live_enabled")]
    public bool? IsModeratorSendLiveEnabled { get; set; }
    /// <summary>
    /// <para>Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.</para>
    /// </summary>
    [JsonPropertyName("slot_count")]
    public int? SlotCount { get; set; }
    /// <summary>
    /// <para>Flag determining if Browser Sources subscribed to sessions on this channel should output audio</para>
    /// </summary>
    [JsonPropertyName("is_browser_source_audio_enabled")]
    public bool? IsBrowserSourceAudioEnabled { get; set; }
    /// <summary>
    /// <para>This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values: </para>
    /// <para>TILED_LAYOUT: All live guests are tiled within the browser source with the same size.</para>
    /// <para>SCREENSHARE_LAYOUT: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.</para>
    /// <para>HORIZONTAL_LAYOUT: All live guests are arranged in a horizontal bar within the browser source</para>
    /// <para>VERTICAL_LAYOUT: All live guests are arranged in a vertical bar within the browser source</para>
    /// </summary>
    [JsonPropertyName("group_layout")]
    public string? GroupLayout { get; set; }
    /// <summary>
    /// <para>Flag determining if Guest Star should regenerate the auth token associated with the channel’s browser sources. Providing a true value for this will immediately invalidate all browser sources previously configured in your streaming software.</para>
    /// </summary>
    [JsonPropertyName("regenerate_browser_sources")]
    public bool? RegenerateBrowserSources { get; set; }
}