using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class RemovedSuspiciousStatusUserResponse
{
    /// <summary>
    /// <para>An array with one object containing information about the suspicious user action.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<SuspiciousStatusUser>? Data { get; init; }
}