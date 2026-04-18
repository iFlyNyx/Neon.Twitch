using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Tags;

public class StreamTag
{
    /// <summary>
    /// <para>An ID that identifies this tag.</para>
    /// </summary>
    [JsonPropertyName("tag_id")]
    public string? TagId { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether the tag is an automatic tag. An automatic tag is one that Twitch adds to the stream. Broadcasters may not add automatic tags to their channel. The value is true if the tag is an automatic tag; otherwise, false.</para>
    /// </summary>
    [JsonPropertyName("is_auto")]
    public bool? IsAuto { get; set; }
    /// <summary>
    /// <para>A dictionary that contains the localized names of the tag. The key is in the form, <locale>-<country/region>. For example, en-us. The value is the localized name.</para>
    /// </summary>
    [JsonPropertyName("localization_names")]
    public Dictionary<string, string>? LocalizationNames { get; set; }
    /// <summary>
    /// <para>A dictionary that contains the localized descriptions of the tag. The key is in the form, <locale>-<country/region>. For example, en-us. The value is the localized description.</para>
    /// </summary>
    [JsonPropertyName("localization_descriptions")]
    public Dictionary<string, string>? LocalizationDescription { get; set; }
}