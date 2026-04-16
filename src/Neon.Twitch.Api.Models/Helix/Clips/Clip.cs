using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Clips;

public class Clip
{
    /// <summary>
    /// <para>An ID that uniquely identifies the clip.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>A URL to the clip.</para>
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
    /// <summary>
    /// <para>A URL that you can use in an iframe to embed the clip (see <see href="https://dev.twitch.tv/docs/embed/video-and-clips/">Embedding Video and Clips</see>).</para>
    /// </summary>
    [JsonPropertyName("embed_url")]
    public string? EmbedUrl { get; set; }
    /// <summary>
    /// <para>An ID that identifies the broadcaster that the video was clipped from.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; set; }
    /// <summary>
    /// <para>An ID that identifies the user that created the clip.</para>
    /// </summary>
    [JsonPropertyName("creator_id")]
    public string? CreatorId { get; set; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("creator_name")]
    public string? CreatorName { get; set; }
    /// <summary>
    /// <para>An ID that identifies the video that the clip came from. This field contains an empty string if the video is not available.</para>
    /// </summary>
    [JsonPropertyName("video_id")]
    public string? VideoId { get; set; }
    /// <summary>
    /// <para>The ID of the game that was being played when the clip was created.</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; set; }
    /// <summary>
    /// <para>The ISO 639-1 two-letter language code that the broadcaster broadcasts in. For example, en for English. The value is other if the broadcaster uses a language that Twitch doesn’t support.</para>
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }
    /// <summary>
    /// <para>The title of the clip.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The number of times the clip has been viewed.</para>
    /// </summary>
    [JsonPropertyName("view_count")]
    public int? ViewCount { get; set; }
    /// <summary>
    /// <para>The date and time of when the clip was created. The date and time is in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>A URL to a thumbnail image of the clip.</para>
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }
    /// <summary>
    /// <para>The length of the clip, in seconds. Precision is 0.1.</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public float? Duration { get; set; }
    /// <summary>
    /// <para>The zero-based offset, in seconds, to where the clip starts in the video (VOD). Is null if the video is not available or hasn’t been created yet from the live stream (see video_id).</para>
    /// <para>Note that there’s a delay between when a clip is created during a broadcast and when the offset is set. During the delay period, vod_offset is null. The delay is indeterminant but is typically minutes long.</para>
    /// </summary>
    [JsonPropertyName("vod_offset")]
    public int? VodOffset { get; set; }
    /// <summary>
    /// <para>A Boolean value that indicates if the clip is featured or not.</para>
    /// </summary>
    [JsonPropertyName("is_featured")]
    public bool? IsFeatured { get; set; }
}