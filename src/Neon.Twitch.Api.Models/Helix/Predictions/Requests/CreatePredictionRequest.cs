using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Requests;

public class CreatePredictionRequest
{
    /// <summary>
    /// <para>The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    [Required]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The question that the broadcaster is asking. For example, Will I finish this entire pizza? The title is limited to a maximum of 45 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    [Required]
    [MaxLength(45)]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The list of possible outcomes that the viewers may choose from. The list must contain a minimum of 2 choices and up to a maximum of 10 choices.</para>
    /// </summary>
    [JsonPropertyName("outcomes")]
    [Required]
    [MinLength(2)]
    [MaxLength(10)]
    public List<PredictionOutcomeRequest>? Outcomes { get; set; }
    /// <summary>
    /// <para>The length of time (in seconds) that the prediction will run for. The minimum is 30 seconds and the maximum is 1800 seconds (30 minutes).</para>
    /// </summary>
    [JsonPropertyName("prediction_window")]
    [Required]
    public int? PredictionWindow { get; set; }
}