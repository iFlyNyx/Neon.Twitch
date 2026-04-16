using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.CCL;

public class GetContentClassificationLabelsResponse
{
    /// <summary>
    /// <para>A list that contains information about the available content classification labels.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ContentClassificationLabel>? Data { get; set; }
}