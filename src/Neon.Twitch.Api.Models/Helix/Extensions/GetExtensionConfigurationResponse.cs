using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class GetExtensionConfigurationResponse
{
    /// <summary>
    /// <para>The list of requested configuration segments. The list is returned in the same order that you specified the list of segments in the request.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionConfiguration>? Data { get; set; }
}