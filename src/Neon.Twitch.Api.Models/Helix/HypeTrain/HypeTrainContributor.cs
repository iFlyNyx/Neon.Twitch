using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain;

public class HypeTrainContributor
{
    /// <summary>
    /// <para>The ID of the user that made the contribution.</para>
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
    /// <para>The contribution method used. Possible values are: </para>
    /// <para>bits - Cheering with Bits. </para>
    /// <para>subscription - Subscription activity like subscribing or gifting subscriptions. </para>
    /// <para>other - Covers other contribution methods not listed.</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    /// <summary>
    /// <para>The total number of points contributed for the type.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }
}