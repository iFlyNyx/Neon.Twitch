using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class CheckAutomodStatusRequest
{
    /// <summary>
    /// <para>The list of messages to check. The list must contain at least one message and may contain up to a maximum of 100 messages.</para>
    /// </summary>
    [JsonPropertyName("data")]
    [Required]
    [MaxLength(100)]
    public List<AutomodStatusRequest>? Requests { get; set; }
}