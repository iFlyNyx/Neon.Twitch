using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions;

public class Cost
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
    public string? Type { get; init; }
}