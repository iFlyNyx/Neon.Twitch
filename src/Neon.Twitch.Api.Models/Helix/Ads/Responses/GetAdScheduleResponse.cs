using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Ads.Models;

namespace Neon.Twitch.Api.Models.Helix.Ads.Responses;

public class GetAdScheduleResponse
{
    /// <summary>
    /// <para>A list that contains information related to the channel’s ad schedule.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GetAdSchedule>? Data { get; init; }
}