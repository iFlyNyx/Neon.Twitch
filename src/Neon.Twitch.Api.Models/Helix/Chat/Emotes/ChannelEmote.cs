using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Emotes;

public class ChannelEmote : Emote
{
    /// <summary>
    /// <para>The subscriber tier at which the emote is unlocked. This field contains the tier information only if emote_type is set to subscriptions, otherwise, it's an empty string.</para>
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
    /// <summary>
    /// <para>The type of emote. The possible values are:</para>
    /// <para>bitstier | follower | subscriptions</para>
    /// </summary>
    [JsonPropertyName("emote_type")]
    public string? EmoteType { get; set; }
    /// <summary>
    /// <para>An ID that identifies the emote set that the emote belongs to.</para>
    /// </summary>
    [JsonPropertyName("emote_set_id")]
    public string? EmoteSetId  { get; set; }
}