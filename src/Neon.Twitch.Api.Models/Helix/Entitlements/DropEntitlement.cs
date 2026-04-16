using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Entitlements;

public class DropEntitlement
{
    /// <summary>
    /// <para>An ID that identifies the entitlement.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>An ID that identifies the benefit (reward).</para>
    /// </summary>
    [JsonPropertyName("benefit_id")]
    public string? BenefitId { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the entitlement was granted.</para>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; set; }
    /// <summary>
    /// <para>An ID that identifies the user who was granted the entitlement.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>An ID that identifies the game the user was playing when the reward was entitled.</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; set; }
    /// <summary>
    /// <para>The entitlement’s fulfillment status. Possible values are: </para>
    /// <para>CLAIMED | FULFILLED</para>
    /// </summary>
    [JsonPropertyName("fulfillment_status")]
    public string? FulfillmentStatus { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the entitlement was last updated.</para>
    /// </summary>
    [JsonPropertyName("last_updated")]
    public string? LastUpdated { get; set; }
}