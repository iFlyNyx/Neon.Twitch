using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum InviteStatus
{
    [JsonStringEnumMemberName("INVITED")]
    Invited,
    [JsonStringEnumMemberName("ACCEPTED")]
    Accepted,
    [JsonStringEnumMemberName("READY")]
    Ready
}