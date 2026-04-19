using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Entitlements.Models;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Responses;

public class GetDropEntitlementsResponse
{
    /// <summary>
    /// <para>The list of entitlements.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<DropEntitlement>? Data { get; init; }
    /// <summary>
    /// <para>The information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}