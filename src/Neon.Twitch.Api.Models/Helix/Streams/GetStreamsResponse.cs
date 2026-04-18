using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Streams;

public class GetStreamsResponse
{
    /// <summary>
    /// <para>The list of streams.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Stream>? Data { get; set; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}