using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class GetBannedUsersResponse
{
    /// <summary>
    /// <para>The list of users that were banned or put in a timeout.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<BannedUser>? Data { get; init; }
}