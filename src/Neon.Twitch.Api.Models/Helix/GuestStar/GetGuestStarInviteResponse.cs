using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class GetGuestStarInviteResponse
{
    /// <summary>
    /// <para>A list of invite objects describing the invited user as well as their ready status.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GuestStarInvite>? Data { get; set; }
}