using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Charity;

public class CharityCampaign
{
    /// <summary>
    /// <para>An ID that identifies the charity campaign.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>An ID that identifies the broadcaster that’s running the campaign.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; init; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; init; }
    /// <summary>
    /// <para>The charity’s name.</para>
    /// </summary>
    [JsonPropertyName("charity_name")]
    public string? CharityName { get; init; }
    /// <summary>
    /// <para>A description of the charity.</para>
    /// </summary>
    [JsonPropertyName("charity_description")]
    public string? CharityDescription { get; init; }
    /// <summary>
    /// <para>A URL to an image of the charity’s logo. The image’s type is PNG and its size is 100px X 100px.</para>
    /// </summary>
    [JsonPropertyName("charity_logo")]
    public string? CharityLogo { get; init; }
    /// <summary>
    /// <para>A URL to the charity’s website.</para>
    /// </summary>
    [JsonPropertyName("charity_website")]
    public string? CharityWebsite { get; init; }
    /// <summary>
    /// <para>The current amount of donations that the campaign has received.</para>
    /// </summary>
    [JsonPropertyName("current_amount")]
    public Amount? CurrentAmount { get; init; }
    /// <summary>
    /// <para>The campaign’s fundraising goal. This field is null if the broadcaster has not defined a fundraising goal.</para>
    /// </summary>
    [JsonPropertyName("target_amount")]
    public Amount? TargetAmount { get; init; }
}