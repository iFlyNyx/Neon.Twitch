using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum RedemptionStatus
{
    [JsonStringEnumMemberName("CANCELED")]
    Canceled,
    [JsonStringEnumMemberName("FULFILLED")]
    Fulfilled,
    [JsonStringEnumMemberName("UNFULFILLED")]
    Unfulfilled
}