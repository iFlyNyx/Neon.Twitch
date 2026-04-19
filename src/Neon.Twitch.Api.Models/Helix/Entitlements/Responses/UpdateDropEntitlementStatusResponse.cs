using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Entitlements.Models;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Responses;

public class UpdateDropEntitlementStatusResponse
{
    /// <summary>
    /// <para>A list that indicates which entitlements were successfully updated and those that weren’t.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<DropEntitlementStatus>? Data { get; init; }
}