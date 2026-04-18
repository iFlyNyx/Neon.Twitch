using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class GuestStarSession
{
    /// <summary>
    /// <para>ID uniquely representing the Guest Star session.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>List of guests currently interacting with the Guest Star session.</para>
    /// </summary>
    [JsonPropertyName("guests")]
    public List<Guest>? Guests { get; init; }
}