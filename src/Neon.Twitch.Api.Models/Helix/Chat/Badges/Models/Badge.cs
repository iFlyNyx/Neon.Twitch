using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Chat.Badges.Models;

public abstract class Badge
{
    /// <summary>
    /// <para>The list of chat badges. The list is sorted in ascending order by set_id, and within a set, the list is sorted in ascending order by id.</para>
    /// </summary>
    [JsonPropertyName("set_id")]
    public string? SetId { get; init; }
    /// <summary>
    /// <para>The list of chat badges in this set.</para>
    /// </summary>
    [JsonPropertyName("versions")]
    public List<BadgeVersion>? Versions { get; init; }
}