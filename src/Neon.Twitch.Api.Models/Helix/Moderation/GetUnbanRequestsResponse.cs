using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class GetUnbanRequestsResponse
{
    /// <summary>
    /// <para>A list that contains information about the channel's unban requests.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UnbanRequest>? Data { get; set; }
    /// <summary>
    /// <para>Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}