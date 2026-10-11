using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EmoteType
{
    [JsonStringEnumMemberName("bitstier")]
    BitsTier,
    [JsonStringEnumMemberName("follower")]
    Follower,
    [JsonStringEnumMemberName("subscriptions")]
    Subscriptions
}