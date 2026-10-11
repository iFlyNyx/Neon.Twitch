using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.CCL.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum CCLType
{
    [JsonStringEnumMemberName("DebatedSocialIssuesAndPolitics")]
    DebatedSocialIssuesAndPolitics,
    [JsonStringEnumMemberName("DrugsIntoxication")]
    DrugsIntoxication,
    [JsonStringEnumMemberName("SexualThemes")]
    SexualThemes,
    [JsonStringEnumMemberName("ViolentGraphic")]
    ViolentGraphic,
    [JsonStringEnumMemberName("Gambling")]
    Gambling,   
    [JsonStringEnumMemberName("ProfanityVulgarity")]
    ProfanityVulgarity
}