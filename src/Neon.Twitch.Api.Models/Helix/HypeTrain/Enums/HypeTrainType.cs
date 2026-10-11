using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum HypeTrainType
{
    [JsonStringEnumMemberName("treasure")]
    Treasure,
    [JsonStringEnumMemberName("golden_kappa")]
    GoldenKappa,
    [JsonStringEnumMemberName("regular")]
    Regular,
    [JsonStringEnumMemberName("mythic")]
    Mythic,
    [JsonStringEnumMemberName("community")]
    Community
}