using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class WarnUserWarningRequest
{
    /// <summary>
    /// <para>A list that contains information about the warning.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public UserWarningRequest? Request { get; set; }
}