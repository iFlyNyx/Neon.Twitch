using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Charity;

public class CharityCampaignDonation
{
    /// <summary>
    /// <para>An ID that identifies the donation. The ID is unique across campaigns.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>An ID that identifies the charity campaign that the donation applies to.</para>
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string? CampaignId { get; init; }
    /// <summary>
    /// <para>An ID that identifies a user that donated money to the campaign.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>An object that contains the amount of money that the user donated.</para>
    /// </summary>
    [JsonPropertyName("amount")]
    public Amount? Amount { get; init; }
}