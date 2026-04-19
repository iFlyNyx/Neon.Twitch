using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams.Models;

public class Stream
{
    /// <summary>
    /// <para>An ID that identifies the stream. You can use this ID later to look up the video on demand (VOD).</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The ID of the user that’s broadcasting the stream.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The ID of the category or game being played.</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; init; }
    /// <summary>
    /// <para>The name of the category or game being played.</para>
    /// </summary>
    [JsonPropertyName("game_name")]
    public string? GameName { get; init; }
    /// <summary>
    /// <para>The type of stream. Possible values are: live. If an error occurs, this field is set to an empty string.</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    /// <summary>
    /// <para>The stream’s title. Is an empty string if not set.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>The tags applied to the stream.</para>
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string>? Tags { get; init; }
    /// <summary>
    /// <para>The number of users watching the stream.</para>
    /// </summary>
    [JsonPropertyName("viewer_count")]
    public int? ViewerCount { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the broadcast began.</para>
    /// </summary>
    [JsonPropertyName("started_at")]
    public string? StartedAt { get; init; }
    /// <summary>
    /// <para>The language that the stream uses. This is an ISO 639-1 two-letter language code or other if the stream uses a language not in the list of supported stream <see href="https://help.twitch.tv/s/article/languages-on-twitch#streamlang">languages</see>.</para>
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; init; }
    /// <summary>
    /// <para>A URL to an image of a frame from the last 5 minutes of the stream. Replace the width and height placeholders in the URL ({width}x{height}) with the size of the image you want, in pixels.</para>
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; init; }
    /// <summary>
    /// <para>IMPORTANT As of February 28, 2023, this field is deprecated and returns only an empty array. If you use this field, please update your code to use the tags field.</para>
    /// <para>The list of tags that apply to the stream. The list contains IDs only when the channel is steaming live. For a list of possible tags, see <see href="https://www.twitch.tv/directory/all/tags">List of All Tags</see>. The list doesn’t include Category Tags.</para>
    /// </summary>
    [JsonPropertyName("tag_ids")]
    [Obsolete("Deprecated in favor of tags.")]
    public List<string>? TagIds { get; init; }
    /// <summary>
    /// <para>IMPORTANT This field is deprecated and returns only false.</para>
    /// <para>A Boolean value that indicates whether the stream is meant for mature audiences.</para>
    /// </summary>
    [JsonPropertyName("is_mature")]
    [Obsolete("Deprecated and returns only false.")]
    public bool? IsMature { get; init; }
}