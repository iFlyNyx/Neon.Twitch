using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class ExtensionConfiguration
{
    /// <summary>
    /// <para>The type of segment. Possible values are: </para>
    /// <para>broadcaster | developer | global</para>
    /// </summary>
    [JsonPropertyName("segment")]
    public string? Segment { get; init; }
    /// <summary>
    /// <para>The ID of the broadcaster that installed the extension. The object includes this field only if the segment query parameter is set to developer or broadcaster.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId  { get; init; }
    /// <summary>
    /// <para>The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; init; }
    /// <summary>
    /// <para>The version number that identifies this definition of the segment’s data.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; init; }
}