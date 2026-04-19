using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Models;

public class UpdatedConduitShard : ConduitShard
{
    /// <summary>
    /// <para>List of unsuccessful updates.</para>
    /// </summary>
    [JsonPropertyName("errors")]
    public List<ConduitError>? Errors { get; init; }
}