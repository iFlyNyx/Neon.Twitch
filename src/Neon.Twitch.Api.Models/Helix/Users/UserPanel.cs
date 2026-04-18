using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class UserPanel
{
    /// <summary>
    /// <para>A Boolean value that determines the extension’s activation state. If false, the user has not configured this overlay extension.</para>
    /// </summary>
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
    /// <summary>
    /// <para>An ID that identifies the extension.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The extension’s version.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; init; }
    /// <summary>
    /// <para>The extension’s name.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}