using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes.Models;

public class ChannelEmote : Emote
{
    /// <summary>
    /// <para>The subscriber tier at which the emote is unlocked. This field contains the tier information only if emote_type is set to subscriptions, otherwise, it's an empty string.</para>
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; init; }
    /// <summary>
    /// <para>The type of emote. The possible values are:</para>
    /// <para>bitstier | follower | subscriptions</para>
    /// </summary>
    [JsonPropertyName("emote_type")]
    public string? EmoteType { get; init; }
    /// <summary>
    /// <para>An ID that identifies the emote set that the emote belongs to.</para>
    /// </summary>
    [JsonPropertyName("emote_set_id")]
    public string? EmoteSetId  { get; init; }
    /// <summary>
    /// <para>The image URLs for the emote. These image URLs always provide a static, non-animated emote image with a light background.</para>
    /// <para>NOTE: You should use the templated URL in the template field to fetch the image instead of using these URLs.</para>
    /// </summary>
    [JsonPropertyName("images")]
    public Image? Images { get; init; }
}