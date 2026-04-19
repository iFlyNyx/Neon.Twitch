using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Requests;

public class EndPredictionRequest
{
    /// <summary>
    /// <para>The ID of the broadcaster that’s running the prediction. This ID must match the user ID in the user access token.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The ID of the prediction to update.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The status to set the prediction to. Possible case-sensitive values are:</para>
    /// <para>RESOLVED — The winning outcome is determined and the Channel Points are distributed to the viewers who predicted the correct outcome.</para>
    /// <para>CANCELED — The broadcaster is canceling the prediction and sending refunds to the participants.</para>
    /// <para>LOCKED — The broadcaster is locking the prediction, which means viewers may no longer make predictions.</para>
    /// <para>The broadcaster can update an active prediction to LOCKED, RESOLVED, or CANCELED; and update a locked prediction to RESOLVED or CANCELED.</para>
    /// <para>The broadcaster has up to 24 hours after the prediction window closes to resolve the prediction. If not, Twitch sets the status to CANCELED and returns the points.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    /// <summary>
    /// <para>The ID of the winning outcome. You must set this parameter if you set status to RESOLVED.</para>
    /// </summary>
    [JsonPropertyName("winning_outcome_id")]
    public string? WinningOutcomeId { get; set; }
}