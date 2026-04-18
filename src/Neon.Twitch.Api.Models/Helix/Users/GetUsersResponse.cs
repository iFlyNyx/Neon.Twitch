using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class GetUsersResponse
{
    /// <summary>
    /// <para>The list of users.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<User>? Data { get; init; }
}