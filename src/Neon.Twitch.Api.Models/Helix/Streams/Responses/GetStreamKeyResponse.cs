using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Streams.Models;

namespace Neon.Twitch.Api.Models.Helix.Streams.Responses;

public class GetStreamKeyResponse
{
    /// <summary>
    /// <para>A list that contains the channel’s stream key.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamKey>? Data { get; init; }
}