using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Conduits.Models;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Requests;

public class ConduitShardRequest
{
    /// <summary>
    /// <para>Shard ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    [Required]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The transport details that you want Twitch to use when sending you notifications.</para>
    /// </summary>
    [JsonPropertyName("transport")]
    [Required]
    public ConduitShardTransport? Transport { get; set; }
}