using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Requests;

public class PatchConduitShardsRequest
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("conduit_id")]
    [Required]
    public string? ConduitId { get; set; }
    /// <summary>
    /// <para>List of shards to update.</para>
    /// </summary>
    [JsonPropertyName("shards")]
    [Required]
    public List<ConduitShardRequest>? Shards { get; set; }
}