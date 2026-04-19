using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Requests;

public class SetExtensionRequiredConfigurationRequest
{
    /// <summary>
    /// <para>The ID of the extension to update.</para>
    /// </summary>
    [JsonPropertyName("extension_id")]
    [Required]
    public string? ExtensionId { get; set; }
    /// <summary>
    /// <para>The version of the extension to update.</para>
    /// </summary>
    [JsonPropertyName("extension_version")]
    [Required]
    public string? ExtensionVersion { get; set; }
    /// <summary>
    /// <para>The required_configuration string to use with the extension.</para>
    /// </summary>
    [JsonPropertyName("required_configuration")]
    [Required]
    public string? RequiredConfiguration { get; set; }
}