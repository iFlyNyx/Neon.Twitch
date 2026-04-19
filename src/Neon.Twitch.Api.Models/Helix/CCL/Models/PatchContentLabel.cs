using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.CCL.Models;

public class PatchContentLabel
{
    /// <summary>
    /// <para>ID of the <see href="https://help.twitch.tv/s/article/content-classification-labels">Content Classification Labels</see> that must be added/removed from the channel. Can be one of the following values:</para>
    /// <para>DebatedSocialIssuesAndPolitics</para>
    /// <para>DrugsIntoxication</para>
    /// <para>SexualThemes</para>
    /// <para>ViolentGraphic</para>
    /// <para>Gambling</para>
    /// <para>ProfanityVulgarity</para>
    /// </summary>
    [JsonPropertyName("id")]
    [Required]
    public string? Id { get; set; }
    /// <summary>
    /// <para>Boolean flag indicating whether the label should be enabled (true) or disabled for the channel.</para>
    /// </summary>
    [JsonPropertyName("is_enabled")]
    [Required]
    public bool? IsEnabled { get; set; }
}