using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Conduits.Models;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Responses;

public class CreateConduitsResponse
{
    /// <summary>
    /// <para>List of information about the client’s conduits.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Conduit>? Data { get; init; }
}