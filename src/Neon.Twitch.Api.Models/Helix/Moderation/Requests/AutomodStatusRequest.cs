using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

internal class AutomodStatusRequest
{
    /// <summary>
    /// <para>A caller-defined ID used to correlate this message with the same message in the response.</para>
    /// </summary>
    [JsonPropertyName("msg_id")]
    [Required]
    public string? MessageId { get; init; }
    /// <summary>
    /// <para>The message to check.</para>
    /// </summary>
    [JsonPropertyName("msg_text")]
    [Required]
    public string? MessageText { get; init; }
}