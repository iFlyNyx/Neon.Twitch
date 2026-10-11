using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

internal class Emote
{
    /// <summary>
    /// <para>The emote ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The emote set ID.</para>
    /// </summary>
    [JsonPropertyName("emote_set_id")]
    public string? EmoteSetId { get; init; }
    /// <summary>
    /// <para>The ID of the emote owner.</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; init; }
    /// <summary>
    /// <para>The emote formats available.</para>
    /// </summary>
    [JsonPropertyName("format")]
    public List<string>? Formats { get; init; }
}