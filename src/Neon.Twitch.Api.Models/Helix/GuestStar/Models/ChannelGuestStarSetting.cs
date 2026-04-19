using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Models;

public class ChannelGuestStarSetting
{
    /// <summary>
    /// <para>Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.</para>
    /// </summary>
    [JsonPropertyName("is_moderator_send_live_enabled")]
    public bool? IsModeratorSendLiveEnabled { get; init; }
    /// <summary>
    /// <para>Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.</para>
    /// </summary>
    [JsonPropertyName("slot_count")]
    public int? SlotCount { get; init; }
    /// <summary>
    /// <para>Flag determining if Browser Sources subscribed to sessions on this channel should output audio</para>
    /// </summary>
    [JsonPropertyName("is_browser_source_audio_enabled")]
    public bool? IsBrowserSourceAudioEnable { get; init; }
    /// <summary>
    /// <para>This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values: </para>
    /// <para>TILED_LAYOUT: All live guests are tiled within the browser source with the same size.</para>
    /// <para>SCREENSHARE_LAYOUT: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.</para>
    /// </summary>
    [JsonPropertyName("group_layout")]
    public string? GroupLayout { get; init; }
    /// <summary>
    /// <para>View only token to generate browser source URLs</para>
    /// </summary>
    [JsonPropertyName("browser_source_token")]
    public string? BrowserSourceToken { get; init; }
}