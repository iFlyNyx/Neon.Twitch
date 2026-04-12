using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Charity;

public class GetCharityCampaignResponse
{
    /// <summary>
    /// <para>A list that contains the charity campaign that the broadcaster is currently running. The list is empty if the broadcaster is not running a charity campaign; the campaign information is not available after the campaign ends.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<CharityCampaign>? Data { get; set; }
}