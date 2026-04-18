using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Conduits;

public class GetConduitShardsResponse
{
    /// <summary>
    /// <para>List of information about a conduit's shards.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ConduitShard>? Data { get; init; }
    /// <summary>
    /// <para>Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}