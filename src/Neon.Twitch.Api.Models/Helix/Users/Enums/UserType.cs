using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserType
{
    [JsonStringEnumMemberName("admin")]
    Admin,
    [JsonStringEnumMemberName("global_mod")]
    GlobalMod,
    [JsonStringEnumMemberName("staff")]
    Staff,
    [JsonStringEnumMemberName("")]
    Normal
}