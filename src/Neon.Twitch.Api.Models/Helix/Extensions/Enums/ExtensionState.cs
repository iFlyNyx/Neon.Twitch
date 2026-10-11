using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum ExtensionState
{
    [JsonStringEnumMemberName("Approved")]
    Approved,
    [JsonStringEnumMemberName("AssetsUploaded")]
    AssetsUploaded,
    [JsonStringEnumMemberName("Deleted")]
    Deleted,
    [JsonStringEnumMemberName("Deprecated")]
    Deprecated,
    [JsonStringEnumMemberName("InReview")]
    InReview,
    [JsonStringEnumMemberName("InTest")]
    InTest,
    [JsonStringEnumMemberName("PendingAction")]
    PendingAction,
    [JsonStringEnumMemberName("Rejected")]
    Rejected,
    [JsonStringEnumMemberName("Released")]
    Released
}