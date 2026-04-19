using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.GuestStar.Models;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Responses;

public class CreateGuestStarSessionResponse
{
    /// <summary>
    /// <para>Summary of the session details</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GuestStarSession>? Data { get; init; }
}