using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.EventSub.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum SubscriptionMethod
{
    [JsonStringEnumMemberName("webhook")]
    Webhook,
    [JsonStringEnumMemberName("websocket")]
    WebSocket,
    [JsonStringEnumMemberName("conduit")]
    Conduit
}