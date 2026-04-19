using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class GetUserAuthorizationResponse
{
    /// <summary>
    /// <para>List of users and their authorized scopes.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserAuthorization>? Data { get; init; }
}