using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits;

public abstract class ConduitShard
{
    /// <summary>
    /// <para>Shard ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The shard status. The subscriber receives events only for enabled shards. Possible values are:</para>
    /// <para>enabled — The shard is enabled.</para>
    /// <para>webhook_callback_verification_pending — The shard is pending verification of the specified callback URL.</para>
    /// <para>webhook_callback_verification_failed — The specified callback URL failed verification.</para>
    /// <para>notification_failures_exceeded — The notification delivery failure rate was too high.</para>
    /// <para>websocket_disconnected — The client closed the connection.</para>
    /// <para>websocket_failed_ping_pong — The client failed to respond to a ping message.</para>
    /// <para>websocket_received_inbound_traffic — The client sent a non-pong message. Clients may only send pong messages (and only in response to a ping message).</para>
    /// <para>websocket_internal_error — The Twitch WebSocket server experienced an unexpected error.</para>
    /// <para>websocket_network_timeout — The Twitch WebSocket server timed out writing the message to the client.</para>
    /// <para>websocket_network_error — The Twitch WebSocket server experienced a network error writing the message to the client.</para>
    /// <para>websocket_failed_to_reconnect - The client failed to reconnect to the Twitch WebSocket server within the required time after a Reconnect Message.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    /// <summary>
    /// <para>The transport details used to send the notifications.</para>
    /// </summary>
    [JsonPropertyName("transport")]
    public Transport? Transport { get; set; }
}