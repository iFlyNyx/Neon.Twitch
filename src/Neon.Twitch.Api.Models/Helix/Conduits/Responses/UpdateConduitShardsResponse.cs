using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Conduits.Models;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Responses;

public class UpdateConduitShardsResponse
{
    /// <summary>
    /// <para>List of successful shard updates.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UpdatedConduitShard>? Data { get; init; }
}