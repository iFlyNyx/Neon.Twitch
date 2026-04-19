using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Extensions.Models;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Requests;

public class PatchExtensionBitProductRequest
{
    /// <summary>
    /// <para>The product's SKU. The SKU must be unique within an extension. The product's SKU cannot be changed. The SKU may contain only alphanumeric characters, dashes (-), underscores (_), and periods (.) and is limited to a maximum of 255 characters. No spaces.</para>
    /// </summary>
    [JsonPropertyName("sku")]
    [Required]
    [MaxLength(255)]
    public string? Sku { get; set; }
    /// <summary>
    /// <para>An object that contains the product's cost information.</para>
    /// </summary>
    [JsonPropertyName("cost")]
    [Required]
    public ExtensionBitCost? Cost { get; set; }
    /// <summary>
    /// <para>A Boolean value that indicates whether the product is in development. Set to true if the product is in development and not available for public use. The default is false.</para>
    /// </summary>
    [JsonPropertyName("in_development")]
    public bool? InDevelopment { get; set; }
    /// <summary>
    /// <para>The product's name as displayed in the extension. The maximum length is 255 characters.</para>
    /// </summary>
    [JsonPropertyName("display_name")]
    [Required]
    public string? DisplayName { get; set; }
    /// <summary>
    /// <para>The date and time, in RFC3339 format, when the product expires. If not set, the product does not expire. To disable the product, set the expiration date to a date in the past.</para>
    /// </summary>
    [JsonPropertyName("expiration")]
    public string? Expiration { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether Bits product purchase events are broadcast to all instances of the extension on a channel. The events are broadcast via the onTransactionComplete helper callback. The default is false.</para>
    /// </summary>
    [JsonPropertyName("is_broadcast")]
    public bool? IsBroadcast { get; set; }
}