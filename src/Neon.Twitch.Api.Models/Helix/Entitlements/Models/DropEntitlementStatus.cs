using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Models;

public class DropEntitlementStatus
{
    /// <summary>
    /// <para>A string that indicates whether the status of the entitlements in the ids field were successfully updated. Possible values are:</para>
    /// <para>INVALID_ID — The entitlement IDs in the ids field are not valid.</para>
    /// <para>NOT_FOUND — The entitlement IDs in the ids field were not found.</para>
    /// <para>SUCCESS — The status of the entitlements in the ids field were successfully updated.</para>
    /// <para>UNAUTHORIZED — The user or organization identified by the user access token is not authorized to update the entitlements.</para>
    /// <para>UPDATE_FAILED — The update failed. These are considered transient errors and the request should be retried later.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>The list of entitlements that the status in the status field applies to.</para>
    /// </summary>
    [JsonPropertyName("ids")]
    public List<string>? Ids { get; init; }
}