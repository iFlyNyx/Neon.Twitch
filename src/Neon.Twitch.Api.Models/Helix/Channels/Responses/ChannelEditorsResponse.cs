using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Channels.Models;

namespace Neon.Twitch.Api.Models.Helix.Channels.Responses;

public class ChannelEditorsResponse
{
    /// <summary>
    /// <para></para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelEditor>? Data { get; init; }
}