using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Requests;

public class SendExtensionPubSubMessageRequest
{
    /// <summary>
    /// <para>The target of the message. Possible values are:</para>
    /// <para>broadcast | global | whisper-(user-id)</para>
    /// <para>If is_global_broadcast is true, you must set this field to global. The broadcast and global values are mutually exclusive; specify only one of them.</para>
    /// </summary>
    [JsonPropertyName("target")]
    [Required]
    public List<string>? Targets { get; set; }
    /// <summary>
    /// <para>The ID of the broadcaster to send the message to. Don’t include this field if is_global_broadcast is set to true.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the message should be sent to all channels where your extension is active. Set to true if the message should be sent to all channels. The default is false.</para>
    /// </summary>
    [JsonPropertyName("is_global_broadcast")]
    public bool? IsGlobalBroadcast { get; set; }
    /// <summary>
    /// <para>The message to send. The message can be a plain-text string or a string-encoded JSON object. The message is limited to a maximum of 5 KB.</para>
    /// </summary>
    [JsonPropertyName("message")]
    [Required]
    public string? Message { get; set; }
}