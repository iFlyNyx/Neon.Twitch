using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Bits.Models;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Bits.Responses;

public class GetBitsLeaderboardResponse
{
    /// <summary>
    /// <para>A list of leaderboard leaders. The leaders are returned in rank order by how much they’ve cheered. The array is empty if nobody has cheered bits.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<BitLeaderboardUser>? Data { get; init; }
    /// <summary>
    /// <para>The reporting window’s start and end dates, in RFC3339 format. The dates are calculated by using the started_at and period query parameters. If you don’t specify the started_at query parameter, the fields contain empty strings.</para>
    /// </summary>
    [JsonPropertyName("date_range")]
    public DateRange? DateRange { get; init; }
    /// <summary>
    /// <para>The number of ranked users in data. This is the value in the count query parameter or the total number of entries on the leaderboard, whichever is less.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }
}