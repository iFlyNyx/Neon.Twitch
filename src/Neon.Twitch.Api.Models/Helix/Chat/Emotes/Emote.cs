using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes;

public abstract class Emote
{
    /// <summary>
    /// <para>An ID that identifies this emote.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
    /// <summary>
    /// <para>The formats that the emote is available in. For example, if the emote is available only as a static PNG, the array contains only static. But if the emote is available as a static PNG and an animated GIF, the array contains static and animated. The possible formats are:</para>
    /// <para>animated | static</para>
    /// </summary>
    [JsonPropertyName("format")]
    public List<string>? Formats { get; init; }
    /// <summary>
    /// <para>The sizes that the emote is available in. For example, if the emote is available in small and medium sizes, the array contains 1.0 and 2.0. Possible sizes are:</para>
    /// <para>1.0 (28x28px) | 2.0 (56x56px) | 3.0 (112x112px)</para>
    /// </summary>
    [JsonPropertyName("scale")]
    public List<string>? Scales { get; init; }
    /// <summary>
    /// <para>The background themes that the emote is available in. Possible themes are:</para>
    /// <para>dark | light</para>
    /// </summary>
    [JsonPropertyName("theme_mode")]
    public List<string>? Themes { get; init; }
}