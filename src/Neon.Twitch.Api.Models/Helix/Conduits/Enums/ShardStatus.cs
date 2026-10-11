using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ShardStatus
{
    [JsonStringEnumMemberName("enabled")]
    Enabled,
    [JsonStringEnumMemberName("webhook_callback_verification_pending")]
    WebhookCallbackVerificationPending,
    [JsonStringEnumMemberName("webhook_callback_verification_failed")]
    WebhookCallbackVerificationFailed,
    [JsonStringEnumMemberName("notification_failures_exceeded")]
    NotificationFailuresExceeded,
    [JsonStringEnumMemberName("websocket_disconnected")]
    WebsocketDisconnected,
    [JsonStringEnumMemberName("websocket_failed_ping_pong")]
    WebsocketFailedPingPong,
    [JsonStringEnumMemberName("websocket_received_inbound_traffic")]
    WebsocketReceivedInboundTraffic,
    [JsonStringEnumMemberName("websocket_internal_error")]
    WebsocketInternalError,
    [JsonStringEnumMemberName("websocket_network_timeout")]
    WebsocketNetworkTimeout,
    [JsonStringEnumMemberName("websocket_network_error")]
    WebsocketNetworkError,
    [JsonStringEnumMemberName("websocket_failed_to_reconnect")]
    WebsocketFailedToReconnect
}