using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Clips.Models;

namespace Neon.Twitch.Api.Models.Helix.Clips.Responses;

public class GetClipDownloadsResponse
{
    /// <summary>
    /// <para>List of clips and their download URLs.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ClipDownload>? Data { get; init; }
}