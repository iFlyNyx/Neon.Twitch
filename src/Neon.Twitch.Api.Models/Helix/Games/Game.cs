using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Games;

public class Game
{
    /// <summary>
    /// <para>An ID that identifies the category or game.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The category’s or game’s name.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// <para>A URL to the category’s or game’s box art. You must replace the {width}x{height} placeholder with the size of image you want.</para>
    /// </summary>
    [JsonPropertyName("box_art_url")]
    public string? BoxArtUrl { get; set; }
    /// <summary>
    /// <para>The ID that <see href="https://www.igdb.com/">IGDB</see> uses to identify this game. If the IGDB ID is not available to Twitch, this field is set to an empty string.</para>
    /// </summary>
    [JsonPropertyName("igdb_id")]
    public string? IgdbUrl { get; set; }
}