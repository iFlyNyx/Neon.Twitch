using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Emotes.Models;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes.Responses;

public class GetUserEmotesResponse
{
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. </para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserEmote>? Data { get; init; }
    /// <summary>
    /// <para>A templated URL. Use the values from the id, format, scale, and theme_mode fields to replace the like-named placeholder strings in the templated URL to create a CDN (content delivery network) URL that you use to fetch the emote. For information about what the template looks like and how to use it to fetch emotes, <see href="https://dev.twitch.tv/docs/irc/emotes#cdn-template">Emote CDN URL format</see>. You should use this template instead of using the URLs in the images object.</para>
    /// </summary>
    [JsonPropertyName("template")]
    public string? Template { get; init; }
    /// <summary>
    /// <para></para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}