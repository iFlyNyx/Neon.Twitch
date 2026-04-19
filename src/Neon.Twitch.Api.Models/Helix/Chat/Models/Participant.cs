using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

public class Participant
{
    /// <summary>
    /// <para>The User ID of the participant channel.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
}