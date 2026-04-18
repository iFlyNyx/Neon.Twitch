using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes;

public class GetEmoteSetResponse
{
    /// <summary>
    /// <para>The list of emotes found in the specified emote sets. The list is empty if none of the IDs were found. The list is in the same order as the set IDs specified in the request. Each set contains one or more emoticons.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<EmoteSet>? Data { get; init; }
    /// <summary>
    /// <para>A templated URL. Use the values from the id, format, scale, and theme_mode fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote. For information about what the template looks like and how to use it to fetch emotes, <see href="https://dev.twitch.tv/docs/irc/emotes#cdn-template">Emote CDN URL format</see>. You should use this template instead of using the URLs in the images object.</para>
    /// </summary>
    [JsonPropertyName("template")]
    public string? Template { get; init; }
}