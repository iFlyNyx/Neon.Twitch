using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class ExtensionBitProduct
{
    /// <summary>
    /// <para>The product’s SKU. The SKU is unique across an extension’s products.</para>
    /// </summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; init; }
    /// <summary>
    /// <para>An object that contains the product’s cost information.</para>
    /// </summary>
    [JsonPropertyName("cost")]
    public Cost? Cost { get; init; }
    /// <summary>
    /// <para>A Boolean value that indicates whether the product is in development. If true, the product is not available for public use.</para>
    /// </summary>
    [JsonPropertyName("in_development")]
    public bool? InDevelopment { get; init; }
    /// <summary>
    /// <para>The product’s name as displayed in the extension.</para>
    /// </summary>
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
    /// <summary>
    /// <para>The date and time, in RFC3339 format, when the product expires.</para>
    /// </summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether Bits product purchase events are broadcast to all instances of an extension on a channel. The events are broadcast via the onTransactionComplete helper callback. Is true if the event is broadcast to all instances.</para>
    /// </summary>
    [JsonPropertyName("is_broadcast")]
    public bool? IsBroadcast { get; init; }
}