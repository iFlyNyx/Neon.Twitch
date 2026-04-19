using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes.Models;

public class GlobalEmote : Emote
{
    /// <summary>
    /// <para>The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.</para>
    /// <para>NOTE: You should use the templated URL in the template field to fetch the image instead of using these URLs.</para>
    /// </summary>
    [JsonPropertyName("images")]
    public Image? Images { get; init; }
}