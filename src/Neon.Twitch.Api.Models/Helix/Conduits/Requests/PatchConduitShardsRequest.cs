using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Requests;

internal class PatchConduitShardsRequest
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("conduit_id")]
    [Required]
    public string? ConduitId { get; init; }
    /// <summary>
    /// <para>List of shards to update.</para>
    /// </summary>
    [JsonPropertyName("shards")]
    [Required]
    public List<ConduitShardRequest>? Shards { get; init; }
}