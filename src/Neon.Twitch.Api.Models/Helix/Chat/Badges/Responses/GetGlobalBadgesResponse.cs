using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Badges.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Badges.Responses;

public class GetGlobalBadgesResponse
{
    /// <summary>
    /// <para>The list of chat badges. The list is sorted in ascending order by set_id, and within a set, the list is sorted in ascending order by id.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<GlobalBadge>? Data { get; init; }
}