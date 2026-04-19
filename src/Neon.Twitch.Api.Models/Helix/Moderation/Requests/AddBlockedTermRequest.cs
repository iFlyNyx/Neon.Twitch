using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class AddBlockedTermRequest
{
    /// <summary>
    /// <para>The word or phrase to block from being used in the broadcaster’s chat room. The term must contain a minimum of 2 characters and may contain up to a maximum of 500 characters.</para>
    /// <para>Terms may include a wildcard character (*). The wildcard character must appear at the beginning or end of a word or set of characters. For example, *foo or foo*.</para>
    /// <para>If the blocked term already exists, the response contains the existing blocked term.</para>
    /// </summary>
    [JsonPropertyName("text")]
    [Required]
    [MinLength(2)]
    [MaxLength(500)]
    public string? Text { get; set; }
}