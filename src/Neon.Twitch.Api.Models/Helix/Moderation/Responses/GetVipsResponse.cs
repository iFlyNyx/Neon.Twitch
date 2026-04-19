using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class GetVipsResponse
{
    /// <summary>
    /// <para>The list of VIPs. The list is empty if the broadcaster doesn’t have VIP users.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<User>? Data { get; init; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}