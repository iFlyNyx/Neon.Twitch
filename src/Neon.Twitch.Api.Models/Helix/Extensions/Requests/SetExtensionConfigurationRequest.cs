using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Requests;

public class SetExtensionConfigurationRequest
{
    /// <summary>
    /// <para>The ID of the extension to update.</para>
    /// </summary>
    [JsonPropertyName("extension_id")]
    [Required]
    public string? ExtensionId { get; set; }
    /// <summary>
    /// <para>The configuration segment to update. Possible case-sensitive values are:</para>
    /// <para>broadcaster | developer | global</para>
    /// </summary>
    [JsonPropertyName("segment")]
    [Required]
    public string? Segment { get; set; }
    /// <summary>
    /// <para>The ID of the broadcaster that installed the extension. Include this field only if the segment is set to developer or broadcaster.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.</para>
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    /// <summary>
    /// <para>The version number that identifies this definition of the segment’s data. If not specified, the latest definition is updated.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}