using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class GetUserActiveExtensionsResponse
{
    /// <summary>
    /// <para>The active extensions that the broadcaster has installed.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserActiveExtension>? Data { get; init; }
}