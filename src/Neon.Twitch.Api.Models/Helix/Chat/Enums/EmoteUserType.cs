using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum EmoteUserType
{
    [JsonStringEnumMemberName("none")]
    None,
    [JsonStringEnumMemberName("bitstier")]
    BitsTier,
    [JsonStringEnumMemberName("follower")]
    Follower,
    [JsonStringEnumMemberName("subscriptions")]
    Subscriptions,
    [JsonStringEnumMemberName("channelpoints")]
    ChannelPoints,
    [JsonStringEnumMemberName("rewards")]
    Rewards,
    [JsonStringEnumMemberName("hypetrain")]
    HypeTrain,
    [JsonStringEnumMemberName("prime")]
    Prime,
    [JsonStringEnumMemberName("turbo")]
    Turbo,
    [JsonStringEnumMemberName("smilies")]
    Smilies,
    [JsonStringEnumMemberName("globals")]
    Globals,
    [JsonStringEnumMemberName("owl2019")]
    Owl2019,
    [JsonStringEnumMemberName("twofactor")]
    TwoFactor,
    [JsonStringEnumMemberName("limitedtime")]
    LimitedTime
}