using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.CCL.Models;

namespace Neon.Twitch.Api.Models.Helix.CCL.Responses;

internal class GetContentClassificationLabelsResponse
{
    /// <summary>
    /// <para>A list that contains information about the available content classification labels.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ContentClassificationLabel>? Data { get; init; }
}