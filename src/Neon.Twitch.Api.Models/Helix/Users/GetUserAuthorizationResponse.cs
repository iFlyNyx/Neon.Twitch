using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class GetUserAuthorizationResponse
{
    /// <summary>
    /// <para>List of users and their authorized scopes.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserAuthorization>? Data { get; init; }
}