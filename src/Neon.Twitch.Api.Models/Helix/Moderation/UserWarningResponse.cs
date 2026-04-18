using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class UserWarningResponse
{
    /// <summary>
    /// <para>A list that contains information about the warning.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserWarning>? Data { get; set; }
}