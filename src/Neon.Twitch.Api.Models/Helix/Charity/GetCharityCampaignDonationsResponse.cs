using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Charity;

public class GetCharityCampaignDonationsResponse
{
    /// <summary>
    /// <para>A list that contains the donations that users have made to the broadcaster’s charity campaign. The list is empty if the broadcaster is not currently running a charity campaign; the donation information is not available after the campaign ends.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CharityCampaignDonation>? Data { get; set; }
    /// <summary>
    /// <para>An object that contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; set; }
}