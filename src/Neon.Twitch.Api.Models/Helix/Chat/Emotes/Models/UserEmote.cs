using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Enums;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes.Models;

internal class UserEmote : Emote
{
    /// <summary>
    /// <para>The type of emote. The possible values are: </para>
    /// <para>none | bitstier | follower | subscriptions | channelpoints | rewards | hypetrain | prime | turbo | smilies | globals | owl2019 | twofactor | limitedtime</para>
    /// </summary>
    [JsonPropertyName("emote_type")]
    public EmoteUserType? EmoteType { get; init; }
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