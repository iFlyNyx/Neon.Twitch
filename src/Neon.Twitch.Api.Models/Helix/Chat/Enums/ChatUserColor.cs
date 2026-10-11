using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ChatUserColor
{
    [JsonStringEnumMemberName("blue")]
    Blue,
    [JsonStringEnumMemberName("blue_violet")]
    BlueViolet,
    [JsonStringEnumMemberName("cadet_blue")]
    CadetBlue,
    [JsonStringEnumMemberName("chocolate")]
    Chocolate,
    [JsonStringEnumMemberName("coral")]
    Coral,
    [JsonStringEnumMemberName("dodger_blue")]
    DodgerBlue,
    [JsonStringEnumMemberName("firebrick")]
    Firebrick,
    [JsonStringEnumMemberName("golden_rod")]
    GoldenRod,
    [JsonStringEnumMemberName("green")]
    Green,
    [JsonStringEnumMemberName("hot_pink")]
    HotPink,
    [JsonStringEnumMemberName("orange_red")]
    OrangeRed,
    [JsonStringEnumMemberName("red")]
    Red,
    [JsonStringEnumMemberName("sea_green")]
    SeaGreen,
    [JsonStringEnumMemberName("spring_green")]
    SpringGreen,
    [JsonStringEnumMemberName("yellow_green")]
    YellowGreen
}