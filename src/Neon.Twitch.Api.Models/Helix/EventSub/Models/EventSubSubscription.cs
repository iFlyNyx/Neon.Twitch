using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.EventSub.Models;

public class EventSubSubscription
{
    /// <summary>
    /// <para>An ID that identifies the subscription.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The subscription’s status. The subscriber receives events only for enabled subscriptions. Possible values are:</para>
    /// <para>enabled — The subscription is enabled.</para>
    /// <para>webhook_callback_verification_pending — The subscription is pending verification of the specified callback URL (see <see href="https://dev.twitch.tv/docs/eventsub/handling-webhook-events#responding-to-a-challenge-request">Responding to a challenge request</see>).</para>
    /// <para>webhook_callback_verification_failed — The specified callback URL failed verification.</para>
    /// <para>notification_failures_exceeded — The notification delivery failure rate was too high.</para>
    /// <para>authorization_revoked — The authorization was revoked for one or more users specified in the Condition object.</para>
    /// <para>moderator_removed — The moderator that authorized the subscription is no longer one of the broadcaster's moderators.</para>
    /// <para>user_removed — One of the users specified in the Condition object was removed.</para>
    /// <para>version_removed — The subscription to subscription type and version is no longer supported.</para>
    /// <para>beta_maintenance — The subscription to the beta subscription type was removed due to maintenance.</para>
    /// <para>websocket_disconnected — The client closed the connection.</para>
    /// <para>websocket_failed_ping_pong — The client failed to respond to a ping message.</para>
    /// <para>websocket_received_inbound_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).</para>
    /// <para>websocket_connection_unused — The client failed to subscribe to events within the required time.</para>
    /// <para>websocket_internal_error — The Twitch WebSocket server experienced an unexpected error.</para>
    /// <para>websocket_network_timeout — The Twitch WebSocket server timed out writing the message to the client.</para>
    /// <para>websocket_network_error — The Twitch WebSocket server experienced a network error writing the message to the client.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>The subscription’s type. See <see href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types">Subscription Types</see>.</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    /// <summary>
    /// <para>The version number that identifies this definition of the subscription’s data.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; init; }
    /// <summary>
    /// <para>The subscription’s parameter values. This is a string-encoded JSON object whose contents are determined by the subscription type.</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public Dictionary<string, string>? Condition { get; init; }
    /// <summary>
    /// <para>The date and time (in RFC3339 format) of when the subscription was created.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
    /// <summary>
    /// <para>The transport details used to send the notifications.</para>
    /// </summary>
    [JsonPropertyName("transport")]
    public Transport? Transport { get; init; }
    /// <summary>
    /// <para>The amount that the subscription counts against your limit. <see href="https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits">Learn More</see></para>
    /// </summary>
    [JsonPropertyName("cost")]
    public int? Cost { get; init; }
}