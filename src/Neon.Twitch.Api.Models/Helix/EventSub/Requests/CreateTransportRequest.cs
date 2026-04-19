using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.EventSub.Requests;

public class CreateTransportRequest
{
    /// <summary>
    /// <para>The transport method. Possible values are:</para>
    /// <para>webhook | websocket | conduit</para>
    /// </summary>
    [JsonPropertyName("method")]
    [Required]
    public string? Method { get; set; }
    /// <summary>
    /// <para>The callback URL where the notifications are sent. The URL must use the HTTPS protocol and port 443. See <see href="https://dev.twitch.tv/docs/eventsub/handling-webhook-events#processing-an-event">Processing an event</see>. Specify this field only if method is set to webhook.</para>
    /// <para>NOTE: Redirects are not followed.</para>
    /// </summary>
    [JsonPropertyName("callback")]
    public string? Callback { get; set; }
    /// <summary>
    /// <para>The secret used to verify the signature. The secret must be an ASCII string that’s a minimum of 10 characters long and a maximum of 100 characters long. For information about how the secret is used, see <see href="https://dev.twitch.tv/docs/eventsub/handling-webhook-events#verifying-the-event-message">Verifying the event message</see>. Specify this field only if method is set to webhook.</para>
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }
    /// <summary>
    /// <para>An ID that identifies the WebSocket to send notifications to. When you connect to EventSub using WebSockets, the server returns the ID in the Welcome message. Specify this field only if method is set to websocket.</para>
    /// </summary>
    [JsonPropertyName("session_id")]
    public string? SessionId { get; set; }
    /// <summary>
    /// <para>An ID that identifies the conduit to send notifications to. When you create a conduit, the server returns the conduit ID. Specify this field only if method is set to conduit.</para>
    /// </summary>
    [JsonPropertyName("conduit_id")]
    public string? ConduitId { get; set; }
}