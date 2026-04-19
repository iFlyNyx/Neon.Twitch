using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes.Models;

public class UserEmote : Emote
{
    /// <summary>
    /// <para>The type of emote. The possible values are: </para>
    /// <para>none | bitstier | follower | subscriptions | channelpoints | rewards | hypetrain | prime | turbo | smilies | globals | owl2019 | twofactor | limitedtime</para>
    /// </summary>
    [JsonPropertyName("emote_type")]
    public string? EmoteType { get; init; }
    /// <summary>
    /// <para>An ID that identifies the emote set that the emote belongs to.</para>
    /// </summary>
    [JsonPropertyName("emote_set_id")]
    public string? EmoteSetId { get; init; }
    /// <summary>
    /// <para>The ID of the broadcaster who owns the emote.</para>
    /// </summary>
    [JsonPropertyName("owner_id")]
    public string? OwnerId { get; init; }
}