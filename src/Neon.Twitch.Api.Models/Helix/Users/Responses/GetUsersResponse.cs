using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class GetUsersResponse
{
    /// <summary>
    /// <para>The list of users.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<User>? Data { get; init; }
}