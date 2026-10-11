using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Enums;

namespace Neon.Twitch.Api.Models.Helix.Chat.Models;

internal class Fragment
{
    /// <summary>
    /// <para>The fragment type. Possible values: text | emote | cheermote | mention</para>
    /// </summary>
    [JsonPropertyName("type")]
    public FragmentType? Type { get; init; }
    /// <summary>
    /// <para>Fragment text.</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; init; }
    /// <summary>
    /// <para>Cheermote metadata. Null if not a cheermote fragment.</para>
    /// </summary>
    [JsonPropertyName("cheermote")]
    public Cheermote? Cheermote { get; init; }
    /// <summary>
    /// <para>Emote metadata. Null if not an emote fragment.</para>
    /// </summary>
    [JsonPropertyName("emote")]
    public Emote? Emote { get; init; }
    /// <summary>
    /// <para>Mention metadata. Null if not a mention fragment.</para>
    /// </summary>
    [JsonPropertyName("mention")]
    public Mention? Mention { get; init; }
}