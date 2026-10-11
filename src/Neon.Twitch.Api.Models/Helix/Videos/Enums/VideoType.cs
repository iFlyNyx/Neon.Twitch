using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Videos.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum VideoType
{
    [JsonStringEnumMemberName("all")]
    All,
    [JsonStringEnumMemberName("archive")]
    Archive,
    [JsonStringEnumMemberName("highlight")]
    Highlight,
    [JsonStringEnumMemberName("upload")]
    Upload
}