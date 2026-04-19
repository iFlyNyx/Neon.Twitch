using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class ExtensionTransaction
{
    /// <summary>
    /// <para>An ID that identifies the transaction.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of the transaction.</para>
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string? Timestamp { get; init; }
    /// <summary>
    /// <para>The ID of the broadcaster that owns the channel where the transaction occurred.</para>
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
    /// <para>The ID of the user that purchased the digital product.</para>
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
    /// <para>The type of transaction. Possible values are: BITS_IN_EXTENSION</para>
    /// </summary>
    [JsonPropertyName("product_type")]
    public string? ProductType { get; init; }
    /// <summary>
    /// <para>Contains details about the digital product.</para>
    /// </summary>
    [JsonPropertyName("product_data")]
    public ProductData? ProductData { get; init; }
}