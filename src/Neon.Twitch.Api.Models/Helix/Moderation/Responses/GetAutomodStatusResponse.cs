using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class GetAutomodStatusResponse
{
    /// <summary>
    /// <para>The list of messages and whether Twitch would approve them for chat.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<AutomodStatus>? Data { get; init; }
}