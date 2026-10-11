using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum BitsType
{
    [JsonStringEnumMemberName("global_first_party")]
    GlobalFirstParty,
    [JsonStringEnumMemberName("global_third_party")]
    GlobalThirdParty,
    [JsonStringEnumMemberName("channel_custom")]
    ChannelCustom,
    [JsonStringEnumMemberName("display_only")]
    DisplayOnly,
    [JsonStringEnumMemberName("sponsored")]
    Sponsored
}