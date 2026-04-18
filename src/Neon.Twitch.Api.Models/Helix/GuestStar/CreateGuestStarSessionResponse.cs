using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class CreateGuestStarSessionResponse
{
    /// <summary>
    /// <para>Summary of the session details</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GuestStarSession>? Data { get; init; }
}