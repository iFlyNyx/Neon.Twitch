using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Requests;

public class PredictionOutcomeRequest
{
    /// <summary>
    /// <para>The text of one of the outcomes that the viewer may select. The title is limited to a maximum of 25 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    [Required]
    [MaxLength(25)]
    public string? Title { get; set; }
}