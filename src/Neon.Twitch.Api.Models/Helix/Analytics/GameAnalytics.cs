using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Analytics;

public class GameAnalytics
{
    /// <summary>
    /// <para>An ID that identifies the game that the report was generated for.</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; set; }
    /// <summary>
    /// <para>The URL that you use to download the report. The URL is valid for 5 minutes.</para>
    /// </summary>
    [JsonPropertyName("URL")]
    public string? Url  { get; set; }
    /// <summary>
    /// <para>The type of report.</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// <para>The reporting window’s start and end dates, in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("date_range")]
    public DateRange? DateRange { get; set; }
}