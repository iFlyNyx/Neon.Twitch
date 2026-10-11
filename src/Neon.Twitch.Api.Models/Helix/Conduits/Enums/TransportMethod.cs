using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum TransportMethod
{
    [JsonStringEnumMemberName("webhook")]
    Webhook,
    [JsonStringEnumMemberName("websocket")]
    WebSocket
}