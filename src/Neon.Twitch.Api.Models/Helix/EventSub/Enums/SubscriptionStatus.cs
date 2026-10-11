using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.EventSub.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum SubscriptionStatus
{
    [JsonStringEnumMemberName("enabled")]
    Enabled,
    [JsonStringEnumMemberName("webhook_callback_verification_pending")]
    WebhookCallbackVerificationPending,
    [JsonStringEnumMemberName("webhook_callback_verification_failed")]
    WebhookCallbackVerificationFailed,
    [JsonStringEnumMemberName("notification_failures_exceeded")]
    NotificationFailuresExceeded,
    [JsonStringEnumMemberName("authorization_revoked")]
    AuthorizationRevoked,
    [JsonStringEnumMemberName("moderator_removed")]
    ModeratorRemoved,
    [JsonStringEnumMemberName("user_removed")]
    UserRemoved,
    [JsonStringEnumMemberName("chat_user_banned")]
    ChatUserBanned,
    [JsonStringEnumMemberName("version_removed")]
    VersionRemoved,
    [JsonStringEnumMemberName("beta_maintenance")]
    BetaMaintenance,
    [JsonStringEnumMemberName("websocket_disconnected")]
    WebsocketDisconnected,
    [JsonStringEnumMemberName("websocket_failed_ping_pong")]
    WebsocketFailedPingPong,
    [JsonStringEnumMemberName("websocket_received_inbound_traffic")]
    WebsocketReceivedInboundTraffic,
    [JsonStringEnumMemberName("websocket_connection_unused")]
    WebsocketConnectionUnused,
    [JsonStringEnumMemberName("websocket_internal_error")]
    WebsocketInternalError,
    [JsonStringEnumMemberName("websocket_network_timeout")]
    WebsocketNetworkTimeout,
    [JsonStringEnumMemberName("websocket_network_error")]
    WebsocketNetworkError,
    [JsonStringEnumMemberName("websocket_failed_to_reconnect")]
    WebsocketFailedToReconnect,
    [JsonStringEnumMemberName("conduit_deleted")]
    ConduitDeleted
}