using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class GetAutomodStatusResponse
{
    /// <summary>
    /// <para>The list of messages and whether Twitch would approve them for chat.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<AutomodStatus>? Data { get; set; }
}