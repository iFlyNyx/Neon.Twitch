using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class GetUserExtensionsResponse
{
    /// <summary>
    /// <para>The list of extensions that the user has installed.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserExtension>? Data { get; set; }
}