using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.CCL;

public class ContentLabel
{
    /// <summary>
    /// <para>Unique identifier for the CCL.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>Localized description of the CCL.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    /// <summary>
    /// <para>Localized name of the CCL.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}