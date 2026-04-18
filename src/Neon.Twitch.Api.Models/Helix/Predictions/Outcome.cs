using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class Outcome
{
    /// <summary>
    /// <para>An ID that identifies this outcome.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The outcome’s text.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>The number of unique viewers that chose this outcome.</para>
    /// </summary>
    [JsonPropertyName("users")]
    public int? Users { get; init; }
    /// <summary>
    /// <para>The number of Channel Points spent by viewers on this outcome.</para>
    /// </summary>
    [JsonPropertyName("channel_points")]
    public int? ChannelPoints { get; init; }
    /// <summary>
    /// <para>A list of viewers who were the top predictors; otherwise, null if none.</para>
    /// </summary>
    [JsonPropertyName("top_predictors")]
    public List<Predictor>? Predictors { get; init; }
    /// <summary>
    /// <para>The color that visually identifies this outcome in the UX. Possible values are: BLUE | PINK</para>
    /// <para>If the number of outcomes is two, the color is BLUE for the first outcome and PINK for the second outcome. If there are more than two outcomes, the color is BLUE for all outcomes.</para>
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; init; }
}