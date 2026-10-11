using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum RedemptionSort
{
    [JsonStringEnumMemberName("OLDEST")]
    Oldest,
    [JsonStringEnumMemberName("NEWEST")]
    Newest
}