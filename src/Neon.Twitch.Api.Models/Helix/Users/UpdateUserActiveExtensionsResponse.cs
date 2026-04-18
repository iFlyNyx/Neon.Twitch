using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class UpdateUserActiveExtensionsResponse
{
    /// <summary>
    /// <para>The extensions that the broadcaster updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserActiveExtension>? Data { get; init; }
}