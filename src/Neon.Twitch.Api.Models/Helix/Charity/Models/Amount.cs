using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Charity.Models;

public class Amount
{
    /// <summary>
    /// <para>The monetary amount. The amount is specified in the currency’s minor unit. For example, the minor units for USD is cents, so if the amount is $5.50 USD, value is set to 550.</para>
    /// </summary>
    [JsonPropertyName("value")]
    public int? Value { get; init; }
    /// <summary>
    /// <para>The number of decimal places used by the currency. For example, USD uses two decimal places. Use this number to translate value from minor units to major units by using the formula: value / 10 ^ decimal_places</para>
    /// </summary>
    [JsonPropertyName("decimal_places")]
    public int? DecimalPlaces { get; init; }
    /// <summary>
    /// <para>The ISO-4217 three-letter currency code that identifies the type of currency in value.</para>
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }
}