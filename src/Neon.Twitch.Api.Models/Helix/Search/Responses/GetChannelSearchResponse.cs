using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Search.Models;

namespace Neon.Twitch.Api.Models.Helix.Search.Responses;

public class GetChannelSearchResponse
{
    /// <summary>
    /// <para>The list of channels that match the query. The list is empty if there are no matches.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelSearch>? Data { get; init; }
}