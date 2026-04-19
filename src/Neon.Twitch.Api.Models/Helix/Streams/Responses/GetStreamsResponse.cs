using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;
using Stream = Neon.Twitch.Api.Models.Helix.Streams.Models.Stream;

namespace Neon.Twitch.Api.Models.Helix.Streams.Responses;

public class GetStreamsResponse
{
    /// <summary>
    /// <para>The list of streams.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Stream>? Data { get; init; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}