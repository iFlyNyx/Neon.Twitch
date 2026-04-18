using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class AutomodSettings
{
    /// <summary>
    /// <para>The broadcaster’s ID.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The moderator’s ID.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; set; }
    /// <summary>
    /// <para>The default AutoMod level for the broadcaster. This field is null if the broadcaster has set one or more of the individual settings.</para>
    /// </summary>
    [JsonPropertyName("overall_level")]
    public int? OverallLevel { get; set; }
    /// <summary>
    /// <para>The Automod level for discrimination against disability.</para>
    /// </summary>
    [JsonPropertyName("disability")]
    public int? Disability { get; set; }
    /// <summary>
    /// <para>The Automod level for hostility involving aggression.</para>
    /// </summary>
    [JsonPropertyName("aggression")]
    public int? Aggression { get; set; }
    /// <summary>
    /// <para>The AutoMod level for discrimination based on sexuality, sex, or gender.</para>
    /// </summary>
    [JsonPropertyName("sexuality_sex_or_gender")]
    public int? SexualitySexOrGender { get; set; }
    /// <summary>
    /// <para>The Automod level for discrimination against women.</para>
    /// </summary>
    [JsonPropertyName("misogyny")]
    public int? Misogyny { get; set; }
    /// <summary>
    /// <para>The Automod level for hostility involving name calling or insults.</para>
    /// </summary>
    [JsonPropertyName("bullying")]
    public int? Bullying { get; set; }
    /// <summary>
    /// <para>The Automod level for profanity.</para>
    /// </summary>
    [JsonPropertyName("swearing")]
    public int? Swearing { get; set; }
    /// <summary>
    /// <para>The Automod level for racial discrimination.</para>
    /// </summary>
    [JsonPropertyName("race_ethnicity_or_religion")]
    public int? RaceEthnicityOrReligion { get; set; }
    /// <summary>
    /// <para>The Automod level for sexual content.</para>
    /// </summary>
    [JsonPropertyName("sex_based_terms")]
    public int? SexBasedTerms { get; set; }
}