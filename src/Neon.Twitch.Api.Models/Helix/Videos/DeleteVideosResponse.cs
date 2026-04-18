using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Videos;

public class DeleteVideosResponse
{
    /// <summary>
    /// <para>The list of IDs of the videos that were deleted.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<string>? Data { get; set; }
}