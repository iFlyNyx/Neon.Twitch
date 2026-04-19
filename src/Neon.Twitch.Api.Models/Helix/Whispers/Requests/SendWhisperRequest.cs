using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Whispers.Requests;

public class SendWhisperRequest
{
    /// <summary>
    /// <para>The whisper message to send. The message must not be empty. The maximum message lengths are:</para>
    /// <para>500 characters if the user you're sending the message to hasn't whispered you before.</para>
    /// <para>10,000 characters if the user you're sending the message to has whispered you before.</para>
    /// <para>Messages that exceed the maximum length are truncated.</para>
    /// </summary>
    [JsonPropertyName("message")]
    [Required]
    public string? Message { get; set; }
}