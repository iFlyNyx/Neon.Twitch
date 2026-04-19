using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Extensions.Models;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Responses;

public class GetReleasedExtensionsResponse
{
    /// <summary>
    /// <para>A list that contains the specified extension.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Extension>? Data { get; init; }
}