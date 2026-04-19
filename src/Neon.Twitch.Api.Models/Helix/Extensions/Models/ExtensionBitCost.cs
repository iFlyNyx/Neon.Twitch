using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class ExtensionBitCost
{
    /// <summary>
    /// <para>The product’s price.</para>
    /// </summary>
    [JsonPropertyName("amount")]
    [Required]
    public int? Amount { get; init; }
    /// <summary>
    /// <para>The type of currency. Possible values are:</para>
    /// <para>bits — The minimum price is 1 and the maximum is 10000.</para>
    /// </summary>
    [JsonPropertyName("type")]
    [Required]
    public string? Type { get; init; }
}