using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class GetUserActiveExtensionsResponse
{
    /// <summary>
    /// <para>The active extensions that the broadcaster has installed.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserActiveExtension>? Data { get; init; }
}