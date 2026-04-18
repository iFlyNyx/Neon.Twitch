using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads;

public class GetAdScheduleResponse
{
    /// <summary>
    /// <para>A list that contains information related to the channel’s ad schedule.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetAdSchedule>? Data { get; init; }
}