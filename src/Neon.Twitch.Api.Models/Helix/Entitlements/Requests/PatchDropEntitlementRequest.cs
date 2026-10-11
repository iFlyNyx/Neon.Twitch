using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Entitlements.Enums;
using Neon.Twitch.Api.Models.Helix.Entitlements.Models;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Requests;

internal class PatchDropEntitlementRequest
{
    /// <summary>
    /// <para>A list of IDs that identify the entitlements to update. You may specify a maximum of 100 IDs.</para>
    /// </summary>
    [JsonPropertyName("entitlement_ids")]
    [MaxLength(100)]
    public List<string>? EntitlementIds { get; init; }
    /// <summary>
    /// <para>The fulfillment status to set the entitlements to. Possible values are:</para>
    /// <para>CLAIMED — The user claimed the benefit.</para>
    /// <para>FULFILLED — The developer granted the benefit that the user claimed.</para>
    /// </summary>
    [JsonPropertyName("fulfillment_status")]
    public FulfillmentStatus? FulfillmentStatus { get; init; }
}