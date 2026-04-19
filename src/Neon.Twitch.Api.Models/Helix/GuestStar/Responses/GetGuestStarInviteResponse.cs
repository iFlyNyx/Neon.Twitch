using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.GuestStar.Models;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Responses;

public class GetGuestStarInviteResponse
{
    /// <summary>
    /// <para>A list of invite objects describing the invited user as well as their ready status.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GuestStarInvite>? Data { get; init; }
}