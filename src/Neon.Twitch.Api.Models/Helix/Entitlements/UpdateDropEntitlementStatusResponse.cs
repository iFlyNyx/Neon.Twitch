using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Entitlements;

public class UpdateDropEntitlementStatusResponse
{
    /// <summary>
    /// <para>A list that indicates which entitlements were successfully updated and those that weren’t.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<DropEntitlementStatus>? Data { get; init; }
}