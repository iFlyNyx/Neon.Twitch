using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.GuestStar.Models;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Responses;

public class GetChannelGuestStarSettingsResponse
{
    /// <summary>
    /// <para>Gets the channel settings for configuration of the Guest Star feature for a particular host</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelGuestStarSetting>? Data { get; init; }
}