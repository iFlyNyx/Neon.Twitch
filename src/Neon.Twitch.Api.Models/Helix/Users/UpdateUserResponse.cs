using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class UpdateUserResponse
{
    /// <summary>
    /// <para>A list contains the single user that you updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<User>? Data { get; set; }
}