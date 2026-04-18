using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Schedule;

public class GetStreamScheduleResponse
{
    /// <summary>
    /// <para>The broadcaster’s streaming schedule.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamSchedule>? Data { get; init; }
    /// <summary>
    /// <para>The information used to page through a list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}