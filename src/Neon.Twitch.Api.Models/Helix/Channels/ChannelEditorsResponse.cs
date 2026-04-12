using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Channels;

public class ChannelEditorsResponse
{
    /// <summary>
    /// <para></para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelEditor>? Data { get; set; }
}