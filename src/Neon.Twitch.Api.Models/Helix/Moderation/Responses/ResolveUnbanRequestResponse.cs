using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class ResolveUnbanRequestResponse
{
    /// <summary>
    /// <para>Results of an unban request.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UnbanRequest>? Data { get; init; }
}