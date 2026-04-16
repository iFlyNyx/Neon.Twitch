using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class MediaSetting
{
    /// <summary>
    /// <para>Flag determining whether the host is allowing the guest’s video to be seen or heard within the session.</para>
    /// </summary>
    [JsonPropertyName("is_host_enabled")]
    public bool? IsHostEnabled { get; set; }
    /// <summary>
    /// <para>Flag determining whether the guest is allowing their video to be transmitted to the session.</para>
    /// </summary>
    [JsonPropertyName("is_guest_enabled")]
    public bool? IsGuestEnabled { get; set; }
    /// <summary>
    /// <para>Flag determining whether the guest has an appropriate video device available to be transmitted to the session.</para>
    /// </summary>
    [JsonPropertyName("is_available")]
    public bool? IsAvailable { get; set; }
}