using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class UserExtension
{
    /// <summary>
    /// <para>An ID that identifies the extension.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The extension's version.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; init; }
    /// <summary>
    /// <para>The extension's name.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension is configured and can be activated. Is true if the extension is configured and can be activated.</para>
    /// </summary>
    [JsonPropertyName("can_activate")]
    public bool? CanActivate { get; init; }
    /// <summary>
    /// <para>The extension types that you can activate for this extension. Possible values are:</para>
    /// <para>component | mobile | overlay | panel</para>
    /// </summary>
    [JsonPropertyName("type")]
    public List<string>? Types { get; init; }
}