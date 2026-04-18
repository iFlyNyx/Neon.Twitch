using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Search;

public class CategorySearch
{
    /// <summary>
    /// <para>A URL to an image of the game’s box art or streaming category.</para>
    /// </summary>
    [JsonPropertyName("box_art_url")]
    public string? BoxArtUrl { get; set; }
    /// <summary>
    /// <para>The name of the game or category.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    /// <summary>
    /// <para>An ID that uniquely identifies the game or category.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}