using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Clips;

public class GetClipDownloadsResponse
{
    /// <summary>
    /// <para>List of clips and their download URLs.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ClipDownload>? Data { get; init; }
}