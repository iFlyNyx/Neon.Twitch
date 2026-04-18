using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class Prediction
{
    /// <summary>
    /// <para>An ID that identifies this prediction.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>An ID that identifies the broadcaster that created the prediction.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The broadcaster’s display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; set; }
    /// <summary>
    /// <para>The broadcaster’s login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; set; }
    /// <summary>
    /// <para>The question that the prediction asks. For example, Will I finish this entire pizza?</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The ID of the winning outcome. Is null unless status is RESOLVED.</para>
    /// </summary>
    [JsonPropertyName("winning_outcome_id")]
    public string? WinningOutcomeId { get; set; }
    /// <summary>
    /// <para>The list of possible outcomes for the prediction.</para>
    /// </summary>
    [JsonPropertyName("outcomes")]
    public List<Outcome>? Outcomes { get; set; }
    /// <summary>
    /// <para>The length of time (in seconds) that the prediction will run for.</para>
    /// </summary>
    [JsonPropertyName("prediction_window")]
    public int? PredictionWindow { get; set; }
    /// <summary>
    /// <para>The prediction’s status. Valid values are:</para>
    /// <para>ACTIVE — The Prediction is running and viewers can make predictions.</para>
    /// <para>CANCELED — The broadcaster canceled the Prediction and refunded the Channel Points to the participants.</para>
    /// <para>LOCKED — The broadcaster locked the Prediction, which means viewers can no longer make predictions.</para>
    /// <para>RESOLVED — The winning outcome was determined and the Channel Points were distributed to the viewers who predicted the correct outcome.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    /// <summary>
    /// <para>The UTC date and time of when the Prediction began.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time of when the Prediction ended. If status is ACTIVE, this is set to null.</para>
    /// </summary>
    [JsonPropertyName("ended_at")]
    public string? EndedAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time of when the Prediction was locked. If status is not LOCKED, this is set to null.</para>
    /// </summary>
    [JsonPropertyName("locked_at")]
    public string? LockedAt { get; set; }
}