using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum FulfillmentStatus
{
    [JsonStringEnumMemberName("CLAIMED")]
    Claimed,
    [JsonStringEnumMemberName("FULFILLED")]
    Fulfilled
}