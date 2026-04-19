using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class UpdateUserResponse
{
    /// <summary>
    /// <para>A list contains the single user that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<User>? Data { get; init; }
}