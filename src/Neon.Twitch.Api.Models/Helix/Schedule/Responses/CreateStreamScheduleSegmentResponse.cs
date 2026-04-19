using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Schedule.Models;

namespace Neon.Twitch.Api.Models.Helix.Schedule.Responses;

public class CreateStreamScheduleSegmentResponse
{
    /// <summary>
    /// <para>The broadcaster’s streaming scheduled.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamSchedule>? Data { get; init; }
}