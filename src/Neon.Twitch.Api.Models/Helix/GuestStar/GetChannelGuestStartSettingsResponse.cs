using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class GetChannelGuestStartSettingsResponse
{
    /// <summary>
    /// <para>Gets the channel settings for configuration of the Guest Star feature for a particular host</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelGuestStarSetting>? Data { get; init; }
}