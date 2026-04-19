using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Requests;

public class UpdateChatSettingsRequest
{
    /// <summary>
    /// <para>A Boolean value that determines whether chat messages must contain only emotes.</para>
    /// <para>Set to true if only emotes are allowed; otherwise, false. The default is false.</para>
    /// </summary>
    [JsonPropertyName("emote_mode")]
    public bool? EmoteMode { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster restricts the chat room to followers only.</para>
    /// <para>Set to true if the broadcaster restricts the chat room to followers only; otherwise, false. The default is true.</para>
    /// <para>To specify how long users must follow the broadcaster before being able to participate in the chat room, see the follower_mode_duration field.</para>
    /// </summary>
    [JsonPropertyName("follower_mode")]
    public bool? FollowerMode { get; set; }
    /// <summary>
    /// <para>The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Set only if follower_mode is true. Possible values are: 0 (no restriction) through 129600 (3 months). The default is 0.</para>
    /// </summary>
    [JsonPropertyName("follower_mode_duration")]
    public int? FollowerModeDuration { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message.</para>
    /// <para>Set to true if the broadcaster applies a delay; otherwise, false. The default is false.</para>
    /// <para>To specify the length of the delay, see the non_moderator_chat_delay_duration field.</para>
    /// </summary>
    [JsonPropertyName("non_moderator_chat_delay")]
    public bool? NonModeratorChatDelay { get; set; }
    /// <summary>
    /// <para>The amount of time, in seconds, that messages are delayed before appearing in chat. Set only if non_moderator_chat_delay is true. Possible values are:</para>
    /// <para>2 — 2 second delay (recommended)</para>
    /// <para>4 — 4 second delay</para>
    /// <para>6 — 6 second delay</para>
    /// </summary>
    [JsonPropertyName("non_moderator_chat_delay_duration")]
    public int? NonModeratorChatDelayDuration { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages. Set to true if the broadcaster applies a wait period between messages; otherwise, false. The default is false.</para>
    /// <para>To specify the delay, see the slow_mode_wait_time field.</para>
    /// </summary>
    [JsonPropertyName("slow_mode")]
    public bool? SlowMode { get; set; }
    /// <summary>
    /// <para>The amount of time, in seconds, that users must wait between sending messages. Set only if slow_mode is true.</para>
    /// <para>Possible values are: 3 (3 second delay) through 120 (2 minute delay). The default is 30 seconds.</para>
    /// </summary>
    [JsonPropertyName("slow_mode_wait_time")]
    public int? SlowModeWaitTime { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.</para>
    /// <para>Set to true if the broadcaster restricts the chat room to subscribers only; otherwise, false. The default is false.</para>
    /// </summary>
    [JsonPropertyName("subscriber_mode")]
    public bool? SubscriberMode { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.</para>
    /// <para>Set to true if the broadcaster allows only unique messages; otherwise, false. The default is false.</para>
    /// </summary>
    [JsonPropertyName("unique_chat_mode")]
    public bool? UniqueChatMode { get; set; }
}