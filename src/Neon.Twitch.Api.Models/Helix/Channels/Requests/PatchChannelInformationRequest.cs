using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.CCL.Models;

namespace Neon.Twitch.Api.Models.Helix.Channels.Requests;

public class PatchChannelInformationRequest
{
    /// <summary>
    /// <para>The ID of the game that the user plays. The game is not updated if the ID isn’t a game ID that Twitch recognizes. To unset this field, use “0” or “” (an empty string).</para>
    /// </summary>
    [JsonPropertyName("game_id")]
    public string? GameId { get; set; }
    /// <summary>
    /// <para>The user’s preferred language. Set the value to an ISO 639-1 two-letter language code (for example, en for English). Set to “other” if the user’s preferred language is not a Twitch supported language. The language isn’t updated if the language code isn’t a Twitch supported language.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_language")]
    public string? BroadcasterLanguage { get; set; }
    /// <summary>
    /// <para>The title of the user’s stream. You may not set this field to an empty string.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    /// <summary>
    /// <para>The number of seconds you want your broadcast buffered before streaming it live. The delay helps ensure fairness during competitive play. Only users with Partner status may set this field. The maximum delay is 900 seconds (15 minutes).</para>
    /// </summary>
    [JsonPropertyName("delay")]
    public int? Delay { get; set; }
    /// <summary>
    /// <para>A list of channel-defined tags to apply to the channel. To remove all tags from the channel, set tags to an empty array. Tags help identify the content that the channel streams. <see href="https://help.twitch.tv/s/article/guide-to-tags">Learn More</see></para>
    /// <para>A channel may specify a maximum of 10 tags. Each tag is limited to a maximum of 25 characters and may not be an empty string or contain spaces or special characters. Tags are case insensitive. For readability, consider using camelCasing or PascalCasing.</para>
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string>? Tags { get; set; }
    /// <summary>
    /// <para>List of labels that should be set as the Channel’s CCLs.</para>
    /// </summary>
    [JsonPropertyName("content_classification_labels")]
    public List<PatchContentLabel>? ContentClassificationLabels { get; set; }
    /// <summary>
    /// <para>Boolean flag indicating if the channel has branded content.</para>
    /// </summary>
    [JsonPropertyName("is_branded_content")]
    public bool? IsBrandedContent { get; set; }
}