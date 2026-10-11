using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Extensions.Enums;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

internal class Cost
{
    /// <summary>
    /// <para>The product’s price.</para>
    /// </summary>
    [JsonPropertyName("amount")]
    public int? Amount { get; init; }
    /// <summary>
    /// <para>The type of currency. Possible values are:</para>
    /// <para>bits</para>
    /// </summary>
    [JsonPropertyName("type")]
    public ExtensionType? Type { get; init; }
}