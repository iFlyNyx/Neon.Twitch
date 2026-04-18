using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits;

public class UpdateConduitShardsResponse
{
    /// <summary>
    /// <para>List of successful shard updates.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UpdatedConduitShard>? Data { get; init; }
}