using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum GroupLayout
{
    [JsonStringEnumMemberName("TILED_LAYOUT")]
    TiledLayout,
    [JsonStringEnumMemberName("SCREENSHARE_LAYOUT")]
    ScreenshareLayout,
    [JsonStringEnumMemberName("HORIZONTAL_LAYOUT")]
    HorizontalLayout,
    [JsonStringEnumMemberName("VERTICAL_LAYOUT")]
    VerticalLayout
}