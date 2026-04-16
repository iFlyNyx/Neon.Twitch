using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Clips;

public class CreateVodClipResponse
{
    /// <summary>
    /// <para>A list containing the created clip.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CreatedClip>? Data { get; set; }
}