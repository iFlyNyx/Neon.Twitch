using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Analytics.Models;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Analytics.Responses;

public class GetExtensionAnalyticsResponse
{
    /// <summary>
    /// <para>A list of reports. The reports are returned in no particular order; however, the data within each report is in ascending order by date (newest first). The report contains one row of data per day of the reporting window; the report contains rows for only those days that the extension was used. The array is empty if there are no reports.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionAnalytics>? Data { get; init; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
}