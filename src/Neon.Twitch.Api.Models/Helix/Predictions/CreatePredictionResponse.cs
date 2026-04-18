using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class CreatePredictionResponse
{
    /// <summary>
    /// <para>A list that contains the single prediction that you created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Prediction>? Data { get; set; }
}