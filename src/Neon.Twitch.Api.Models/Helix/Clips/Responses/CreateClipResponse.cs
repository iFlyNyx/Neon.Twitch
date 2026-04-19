using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Clips.Models;

namespace Neon.Twitch.Api.Models.Helix.Clips.Responses;

public class CreateClipResponse
{
    /// <summary>
    /// <para>A list containing the created clip.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CreatedClip>? Data { get; init; }
}