using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Requests;

public class SendExtensionChatMessageRequest
{
    /// <summary>
    /// <para>The message. The message may contain a maximum of 280 characters.</para>
    /// </summary>
    [JsonPropertyName("text")]
    [Required]
    [MaxLength(280)]
    public string? Text { get; set; }
    /// <summary>
    /// <para>The ID of the extension that’s sending the chat message.</para>
    /// </summary>
    [JsonPropertyName("extension_id")]
    [Required]
    public string? ExtensionId { get; set; }
    /// <summary>
    /// <para>The extension’s version number.</para>
    /// </summary>
    [JsonPropertyName("extension_version")]
    [Required]
    public string? ExtensionVersion { get; set; }
}