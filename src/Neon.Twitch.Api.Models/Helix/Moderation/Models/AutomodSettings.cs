using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Enums;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Models;

internal class AutomodSettings
{
    /// <summary>
    /// <para>The broadcaster’s ID.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The moderator’s ID.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; init; }
    /// <summary>
    /// <para>The default AutoMod level for the broadcaster. This field is null if the broadcaster has set one or more of the individual settings.</para>
    /// </summary>
    [JsonPropertyName("overall_level")]
    public AutomodLevel? OverallLevel { get; init; }
    /// <summary>
    /// <para>The Automod level for discrimination against disability.</para>
    /// </summary>
    [JsonPropertyName("disability")]
    public AutomodLevel? Disability { get; init; }
    /// <summary>
    /// <para>The Automod level for hostility involving aggression.</para>
    /// </summary>
    [JsonPropertyName("aggression")]
    public AutomodLevel? Aggression { get; init; }
    /// <summary>
    /// <para>The AutoMod level for discrimination based on sexuality, sex, or gender.</para>
    /// </summary>
    [JsonPropertyName("sexuality_sex_or_gender")]
    public AutomodLevel? SexualitySexOrGender { get; init; }
    /// <summary>
    /// <para>The Automod level for discrimination against women.</para>
    /// </summary>
    [JsonPropertyName("misogyny")]
    public AutomodLevel? Misogyny { get; init; }
    /// <summary>
    /// <para>The Automod level for hostility involving name calling or insults.</para>
    /// </summary>
    [JsonPropertyName("bullying")]
    public AutomodLevel? Bullying { get; init; }
    /// <summary>
    /// <para>The Automod level for profanity.</para>
    /// </summary>
    [JsonPropertyName("swearing")]
    public AutomodLevel? Swearing { get; init; }
    /// <summary>
    /// <para>The Automod level for racial discrimination.</para>
    /// </summary>
    [JsonPropertyName("race_ethnicity_or_religion")]
    public AutomodLevel? RaceEthnicityOrReligion { get; init; }
    /// <summary>
    /// <para>The Automod level for sexual content.</para>
    /// </summary>
    [JsonPropertyName("sex_based_terms")]
    public AutomodLevel? SexBasedTerms { get; init; }
}