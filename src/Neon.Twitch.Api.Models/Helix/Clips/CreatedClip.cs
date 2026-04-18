using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Clips;

public class CreatedClip
{
    /// <summary>
    /// <para>An ID that uniquely identifies the clip.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>A URL that you can use to edit the clip’s title, identify the part of the clip to publish, and publish the clip. <see href="https://help.twitch.tv/s/article/how-to-use-clips">Learn More</see></para>
    /// <para>The URL is valid for up to 24 hours or until the clip is published, whichever comes first.</para>
    /// </summary>
    [JsonPropertyName("edit_url")]
    public string? EditUrl { get; init; }
}