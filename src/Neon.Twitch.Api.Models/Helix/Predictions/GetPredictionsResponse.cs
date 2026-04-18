using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Predictions;

public class GetPredictionsResponse
{
    /// <summary>
    /// <para>The broadcaster’s list of Channel Points Predictions. The list is sorted in descending ordered by when the prediction began (the most recent prediction is first). The list is empty if the broadcaster hasn’t created predictions.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Prediction>? Data { get; set; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}