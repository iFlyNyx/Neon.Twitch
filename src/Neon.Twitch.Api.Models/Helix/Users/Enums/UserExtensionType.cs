using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserExtensionType
{
    [JsonStringEnumMemberName("component")]
    Component,
    [JsonStringEnumMemberName("mobile")]
    Mobile,
    [JsonStringEnumMemberName("overlay")]
    Overlay,
    [JsonStringEnumMemberName("panel")]
    Panel
}