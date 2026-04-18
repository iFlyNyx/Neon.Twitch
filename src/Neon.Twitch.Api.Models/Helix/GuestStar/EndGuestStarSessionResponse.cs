using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class EndGuestStarSessionResponse
{
    /// <summary>
    /// <para>Summary of the session details when the session was ended.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GuestStarSession>? Data { get; init; }
}