using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class GetBlockListUsersResponse
{
    /// <summary>
    /// <para>The list of blocked users. The list is in descending order by when the user was blocked.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<BlockListUser>? Data { get; init; }
}