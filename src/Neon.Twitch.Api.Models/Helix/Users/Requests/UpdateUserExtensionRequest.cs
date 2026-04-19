using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Requests;

public class UpdateUserExtensionRequest
{
    /// <summary>
    /// <para>The extensions to update. The data field is a dictionary of extension types. The dictionary’s possible keys are: panel, overlay, or component. The key’s value is a dictionary of extensions.</para>
    /// <para>For the extension’s dictionary, the key is a sequential number beginning with 1. For panel and overlay extensions, the key’s value is an object that contains the following fields: active (true/false), id (the extension’s ID), and version (the extension’s version).</para>
    /// <para>For component extensions, the key’s value includes the above fields plus the x and y fields, which identify the coordinate where the extension is placed.</para>
    /// </summary>
    [JsonPropertyName("data")]
    [Required]
    public Dictionary<string, string>? Data { get; set; }
}