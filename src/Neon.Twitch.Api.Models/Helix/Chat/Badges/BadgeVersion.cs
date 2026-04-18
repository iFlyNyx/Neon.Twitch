using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Badges;

public class BadgeVersion
{
    /// <summary>
    /// <para>An ID that identifies this version of the badge. The ID can be any value. For example, for Bits, the ID is the Bits tier level, but for World of Warcraft, it could be Alliance or Horde.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>A URL to the small version (18px x 18px) of the badge.</para>
    /// </summary>
    [JsonPropertyName("image_url_1x")]
    public string? ImageUrl1X { get; init; }
    /// <summary>
    /// <para>A URL to the medium version (36px x 36px) of the badge.</para>
    /// </summary>
    [JsonPropertyName("image_url_2x")]
    public string? ImageUrl2X { get; init; }
    /// <summary>
    /// <para>A URL to the large version (72px x 72px) of the badge.</para>
    /// </summary>
    [JsonPropertyName("image_url_4x")]
    public string? ImageUrl4X { get; init; }
    /// <summary>
    /// <para>The title of the badge.</para>
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }
    /// <summary>
    /// <para>The description of the badge.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    /// <summary>
    /// <para>The action to take when clicking on the badge. Set to null if no action is specified.</para>
    /// </summary>
    [JsonPropertyName("click_action")]
    public string? ClickAction { get; init; }
    /// <summary>
    /// <para>The URL to navigate to when clicking on the badge. Set to null if no URL is specified.</para>
    /// </summary>
    [JsonPropertyName("click_url")]
    public string? ClickUrl { get; init; }
}