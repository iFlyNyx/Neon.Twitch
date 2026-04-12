using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Shared;

/// <summary>
/// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
/// <see href="https://dev.twitch.tv/docs/api/guide#pagination">Read More</see>
/// </summary>
public class Pagination
{
    /// <summary>
    /// <para>The cursor used to get the next page of results. Use the cursor to set the request’s after query parameter.</para>
    /// </summary>
    [JsonPropertyName("cursor")]
    public string? Cursor { get; set; }
}