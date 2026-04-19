using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Videos.Models;

public class Video
{
    /// <summary>
    /// <para>An ID that identifies the video.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The ID of the stream that the video originated from if the video's type is "archive;" otherwise, null.</para>
    /// </summary>
    [JsonPropertyName("stream_id")]
    public string? StreamId { get; init; }
    /// <summary>
    /// <para>The ID of the broadcaster that owns the video.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The broadcaster's login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The broadcaster's display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The video's title.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>The video's description.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    /// <summary>
    /// <para>The date and time, in UTC, of when the video was created. The timestamp is in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
    /// <summary>
    /// <para>The date and time, in UTC, of when the video was published. The timestamp is in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("published_at")]
    public string? PublishedAt { get; init; }
    /// <summary>
    /// <para>The video's URL.</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; init; }
    /// <summary>
    /// <para>A URL to a thumbnail image of the video. Before using the URL, you must replace the %{width} and %{height} placeholders with the width and height of the thumbnail you want returned. Due to current limitations, ${width} must be 320 and ${height} must be 180.</para>
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; init; }
    /// <summary>
    /// <para>The video's viewable state. Always set to public.</para>
    /// </summary>
    [JsonPropertyName("viewable")]
    public string? Viewable { get; init; }
    /// <summary>
    /// <para>The number of times that users have watched the video.</para>
    /// </summary>
    [JsonPropertyName("view_count")]
    public int? ViewCount { get; init; }
    /// <summary>
    /// <para>The ISO 639-1 two-letter language code that the video was broadcast in. For example, the language code is DE if the video was broadcast in German. For a list of supported languages, see <see href="https://help.twitch.tv/s/article/languages-on-twitch#streamlang">Supported Stream Language</see>. The language value is "other" if the video was broadcast in a language not in the list of supported languages.</para>
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; init; }
    /// <summary>
    /// <para>The video's type. Possible values are:</para>
    /// <para>archive — An on-demand video (VOD) of one of the broadcaster's past streams.</para>
    /// <para>highlight — A highlight reel of one of the broadcaster's past streams. See <see href="https://help.twitch.tv/s/article/creating-highlights-and-stream-markers">Creating Highlights</see>.</para>
    /// <para>upload — A video that the broadcaster uploaded to their video library. See Upload under <see href="https://help.twitch.tv/s/article/video-on-demand?language=en_US#videoproducer">Video Producer</see>.</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    /// <summary>
    /// <para>The video's length in ISO 8601 duration format. For example, 3m21s represents 3 minutes, 21 seconds.</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; init; }
    /// <summary>
    /// <para>The segments that Twitch Audio Recognition muted; otherwise, null.</para>
    /// </summary>
    [JsonPropertyName("muted_segments")]
    public List<VideoSegment>? MutedSegments { get; init; }
}