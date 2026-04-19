using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Schedule.Models;

public class Vacation
{
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation starts.</para>
    /// </summary>
    [JsonPropertyName("start_time")]
    public string? StartTime { get; init; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation ends.</para>
    /// </summary>
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }
}