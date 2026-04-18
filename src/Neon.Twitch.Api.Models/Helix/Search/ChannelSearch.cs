using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Search;

public class ChannelSearch
{
    /// <summary>
    /// <para>The ISO 639-1 two-letter language code of the language used by the broadcaster. For example, en for English. If the broadcaster uses a language not in the list of <see href="https://help.twitch.tv/s/article/languages-on-twitch#streamlang">supported stream languages</see>, the value is other.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_language")]
    public string? BroadcasterLanguage { get; set; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; set; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; set; }
    /// <summary>
    /// <para>The ID of the game that the broadcaster is playing or last played.</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; set; }
    /// <summary>
    /// <para>The name of the game that the broadcaster is playing or last played.</para>
    /// </summary>
    [JsonPropertyName("game_name")]
    public string? GameName { get; set; }
    /// <summary>
    /// <para>An ID that uniquely identifies the channel (this is the broadcaster’s ID).</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster is streaming live. Is true if the broadcaster is streaming live; otherwise, false.</para>
    /// </summary>
    [JsonPropertyName("is_live")]
    public bool? IsLive { get; set; }
    /// <summary>
    /// <para>IMPORTANT As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the tags field.</para>
    /// <para>The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see <see href="https://www.twitch.tv/directory/all/tags">List of All Tags</see>. The list doesn’t include Category Tags.</para>
    /// </summary>
    [JsonPropertyName("tag_ids")]
    [Obsolete("Deprecated in favor of Tags property.")]
    public List<string>? TagIds { get; set; }
    /// <summary>
    /// <para>The tags applied to the channel.</para>
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }
    /// <summary>
    /// <para>A URL to a thumbnail of the broadcaster’s profile image.</para>
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }
    /// <summary>
    /// <para>The stream’s title. Is an empty string if the broadcaster didn’t set it.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the broadcaster started streaming. The string is empty if the broadcaster is not streaming live.</para>
    /// </summary>
    [JsonPropertyName("started_at")]
    public string? StartedAt { get; set; }
}