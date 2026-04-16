using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class ChatSettings
{
    /// <summary>
    /// <para>The ID of the broadcaster specified in the request.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether chat messages must contain only emotes. Is true if chat messages may contain only emotes; otherwise, false.</para>
    /// </summary>
    [JsonPropertyName("emote_mode")]
    public bool? EmoteMode { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster restricts the chat room to followers only.</para>
    /// <para>Is true if the broadcaster restricts the chat room to followers only; otherwise, false.</para>
    /// <para>See the follower_mode_duration field for how long users must follow the broadcaster before being able to participate in the chat room.</para>
    /// </summary>
    [JsonPropertyName("follower_mode")]
    public bool? FollowerMode { get; set; }
    /// <summary>
    /// <para>The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Is null if follower_mode is false.</para>
    /// </summary>
    [JsonPropertyName("follower_mode_duration")]
    public int? FollowerModeDuration { get; set; }
    /// <summary>
    /// <para>The moderator’s ID. The response includes this field only if the request specifies a user access token that includes the moderator:read:chat_settings scope.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. This gives chat moderators and bots a chance to remove them before viewers can see the message. See the non_moderator_chat_delay_duration field for the length of the delay. Is true if the broadcaster applies a delay; otherwise, false.</para>
    /// <para>The response includes this field only if the request specifies a user access token that includes the moderator:read:chat_settings scope and the user in the moderator_id query parameter is one of the broadcaster’s moderators.</para>
    /// </summary>
    [JsonPropertyName("non_moderator_chat_delay")]
    public bool? NonModeratorChatDelay { get; set; }
    /// <summary>
    /// <para>The amount of time, in seconds, that messages are delayed before appearing in chat. Is null if non_moderator_chat_delay is false.</para>
    /// <para>The response includes this field only if the request specifies a user access token that includes the moderator:read:chat_settings scope and the user in the moderator_id query parameter is one of the broadcaster’s moderators.</para>
    /// </summary>
    [JsonPropertyName("non_moderator_chat_delay_duration")]
    public int? NonModeratorChatDelayDuration { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.</para>
    /// <para>Is true if the broadcaster applies a delay; otherwise, false.</para>
    /// <para>See the slow_mode_wait_time field for the delay.</para>
    /// </summary>
    [JsonPropertyName("slow_mode")]
    public bool? SlowMode { get; set; }
    /// <summary>
    /// <para>The amount of time, in seconds, that users must wait between sending messages.</para>
    /// <para>Is null if slow_mode is false.</para>
    /// </summary>
    [JsonPropertyName("slow_mode_wait_time")]
    public int? SlowModeWaitTime { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.</para>
    /// <para>Is true if the broadcaster restricts the chat room to subscribers only; otherwise, false.</para>
    /// </summary>
    [JsonPropertyName("subscriber_mode")]
    public bool? SubscriberMode { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.</para>
    /// <para>Is true if the broadcaster requires unique messages only; otherwise, false.</para>
    /// </summary>
    [JsonPropertyName("unique_chat_mode")]
    public bool? UniqueChatMode { get; set; }
}