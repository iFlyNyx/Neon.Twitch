using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class UserWarningRequest
{
    /// <summary>
    /// <para>The ID of the twitch user to be warned.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    [Required]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>A custom reason for the warning. Max 500 chars.</para>
    /// </summary>
    [JsonPropertyName("reason")]
    [Required]
    [MaxLength(500)]
    public string? Reason { get; set; }
}