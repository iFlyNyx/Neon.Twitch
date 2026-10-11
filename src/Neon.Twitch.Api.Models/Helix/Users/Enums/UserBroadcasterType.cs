using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum UserBroadcasterType
{
    [JsonStringEnumMemberName("affiliate")]
    Affiliate,
    [JsonStringEnumMemberName("partner")]
    Partner,
    [JsonStringEnumMemberName("")]
    Normal
}