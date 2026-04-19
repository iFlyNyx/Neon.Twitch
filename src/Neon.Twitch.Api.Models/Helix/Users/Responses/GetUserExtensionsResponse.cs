using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class GetUserExtensionsResponse
{
    /// <summary>
    /// <para>The list of extensions that the user has installed.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserExtension>? Data { get; init; }
}