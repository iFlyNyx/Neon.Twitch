using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class GetReleasedExtensionsResponse
{
    /// <summary>
    /// <para>A list that contains the specified extension.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Extension>? Data { get; set; }
}