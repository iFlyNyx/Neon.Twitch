using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Conduits.Models;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Requests;

internal class ConduitShardRequest
{
    /// <summary>
    /// <para>Shard ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    [Required]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The transport details that you want Twitch to use when sending you notifications.</para>
    /// </summary>
    [JsonPropertyName("transport")]
    [Required]
    public ConduitShardTransport? Transport { get; init; }
}