using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Extensions.Models;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Responses;

public class GetExtensionSecretsResponse
{
    /// <summary>
    /// <para>The list of shared secrets that the extension created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionSecret>? Data { get; init; }
}