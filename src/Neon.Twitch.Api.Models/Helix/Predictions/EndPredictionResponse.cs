using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class EndPredictionResponse
{
    /// <summary>
    /// <para>A list that contains the single prediction that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Prediction>? Data { get; init; }
}