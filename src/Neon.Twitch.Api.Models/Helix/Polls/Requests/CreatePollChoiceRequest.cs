using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls.Requests;

public class CreatePollChoiceRequest
{
    /// <summary>
    /// <para>One of the choices the viewer may select. The choice may contain a maximum of 25 characters.</para>
    /// </summary>
    [JsonPropertyName("title")]
    [Required]
    [MaxLength(25)]
    public string? Title { get; set; }
}