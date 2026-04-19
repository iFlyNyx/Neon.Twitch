using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class UserWarningResponse
{
    /// <summary>
    /// <para>A list that contains information about the warning.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserWarning>? Data { get; init; }
}