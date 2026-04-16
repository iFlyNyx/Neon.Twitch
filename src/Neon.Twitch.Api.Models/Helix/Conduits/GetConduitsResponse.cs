using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits;

public class GetConduitsResponse
{
    /// <summary>
    /// <para>List of information about the client’s conduits.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Conduit>? Data { get; set; }
}