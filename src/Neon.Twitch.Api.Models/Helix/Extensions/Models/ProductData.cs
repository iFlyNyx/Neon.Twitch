using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class ProductData
{
    /// <summary>
    /// <para>An ID that identifies the digital product.</para>
    /// </summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }
    /// <summary>
    /// <para>Set to twitch.ext. + the extension's ID.</para>
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; init; }
    /// <summary>
    /// <para>Contains details about the digital product’s cost.</para>
    /// </summary>
    [JsonPropertyName("cost")]
    public Cost? Cost { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the product is in development. Is true if the digital product is in development and cannot be exchanged.</para>
    /// </summary>
    [JsonPropertyName("inDevelopment")]
    public bool? InDevelopment { get; init; }
    /// <summary>
    /// <para>The name of the digital product.</para>
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }
    /// <summary>
    /// <para>This field is always empty since you may purchase only unexpired products.</para>
    /// </summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the data was broadcast to all instances of the extension. Is true if the data was broadcast to all instances.</para>
    /// </summary>
    [JsonPropertyName("broadcast")]
    public bool? Broadcast { get; init; }
}