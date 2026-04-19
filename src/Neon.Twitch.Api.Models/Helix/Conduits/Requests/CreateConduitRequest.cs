using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Requests;

public class CreateConduitRequest
{
    /// <summary>
    /// <para>The number of shards to create for this conduit.</para>
    /// </summary>
    [JsonPropertyName("shard_count")]
    [Required]
    public int? ShardCount { get; set; }
}