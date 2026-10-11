using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum HypeTrainContributionType
{
    [JsonStringEnumMemberName("bits")]
    Bits,
    [JsonStringEnumMemberName("subscription")]
    Subscription,
    [JsonStringEnumMemberName("other")]
    Other
}