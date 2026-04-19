using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Requests;

public class PatchConduitRequest
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    [Required]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The new number of shards for this conduit.</para>
    /// </summary>
    [JsonPropertyName("shard_count")]
    [Required]
    public int? ShardCount { get; set; }
}