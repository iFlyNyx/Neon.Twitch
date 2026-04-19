using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Predictions.Models;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Responses;

public class CreatePredictionResponse
{
    /// <summary>
    /// <para>A list that contains the single prediction that you created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Prediction>? Data { get; init; }
}