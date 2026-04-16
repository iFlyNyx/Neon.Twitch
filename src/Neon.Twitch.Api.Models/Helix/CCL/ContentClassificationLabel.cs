using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.CCL;

public class ContentClassificationLabel
{
    /// <summary>
    /// <para>The list of CCLs available.</para>
    /// </summary>
    [JsonPropertyName("content_classification_labels")]
    public List<ContentLabel>? ContentLabels { get; set; }
}