using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Extensions.Models;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Responses;

public class UpdatedExtensionBitProductResponse
{
    /// <summary>
    /// <para>A list of Bits products that the extension created. The list is in ascending SKU order. The list is empty if the extension hasn't created any products or they're all expired or disabled.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionBitProduct>? Data { get; init; }
}