using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Search;

public class GetChannelSearchResponse
{
    /// <summary>
    /// <para>The list of channels that match the query. The list is empty if there are no matches.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelSearch>? Data { get; set; }
}