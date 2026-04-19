using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Emotes.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes.Responses;

public class GetChannelEmotesResponse
{
    /// <summary>
    /// <para>The list of emotes that the specified broadcaster created. If the broadcaster hasn't created custom emotes, the list is empty.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelEmote>? Data { get; init; }
    /// <summary>
    /// <para>A templated URL. Use the values from the id, format, scale, and theme_mode fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote. For information about what the template looks like and how to use it to fetch emotes, <see href="https://dev.twitch.tv/docs/irc/emotes#cdn-template">Emote CDN URL format</see>. You should use this template instead of using the URLs in the images object.</para>
    /// </summary>
    [JsonPropertyName("template")]
    public string? Template { get; init; }
}