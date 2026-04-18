using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Schedule;

public class CreateStreamSchduleSegmentResponse
{
    /// <summary>
    /// <para>The broadcaster’s streaming scheduled.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamSchedule>? Data { get; init; }
}