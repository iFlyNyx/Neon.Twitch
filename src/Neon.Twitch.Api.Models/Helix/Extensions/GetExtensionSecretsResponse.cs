using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class GetExtensionSecretsResponse
{
    /// <summary>
    /// <para>The list of shared secrets that the extension created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionSecret>? Data { get; init; }
}