using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Predictions.Models;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Responses;

internal class EndPredictionResponse
{
    /// <summary>
    /// <para>A list that contains the single prediction that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Prediction>? Data { get; init; }
}