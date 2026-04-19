using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class ExtensionSecret
{
    /// <summary>
    /// <para>The version number that identifies this definition of the secret’s data.</para>
    /// </summary>
    [JsonPropertyName("format_version")]
    public int? FormatVersion { get; init; }
    /// <summary>
    /// <para>The list of secrets.</para>
    /// </summary>
    [JsonPropertyName("secrets")]
    public List<Secret>? Secrets { get; init; }
}