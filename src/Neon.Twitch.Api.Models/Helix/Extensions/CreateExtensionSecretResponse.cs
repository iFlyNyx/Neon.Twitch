using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class CreateExtensionSecretResponse
{
    /// <summary>
    /// <para>A list that contains the newly added secrets.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionSecret>? Data { get; set; }
}