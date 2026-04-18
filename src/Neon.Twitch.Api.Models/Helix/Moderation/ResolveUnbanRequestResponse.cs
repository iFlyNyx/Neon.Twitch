using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class ResolveUnbanRequestResponse
{
    /// <summary>
    /// <para>Results of an unban request.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UnbanRequest>? Data { get; set; }
}