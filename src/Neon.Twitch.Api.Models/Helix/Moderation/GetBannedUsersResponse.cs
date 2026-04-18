using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class GetBannedUsersResponse
{
    /// <summary>
    /// <para>The list of users that were banned or put in a timeout.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<BannedUser>? Data { get; init; }
}