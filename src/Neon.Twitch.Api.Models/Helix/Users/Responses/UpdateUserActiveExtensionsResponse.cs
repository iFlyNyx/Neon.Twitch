using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Users.Models;

namespace Neon.Twitch.Api.Models.Helix.Users.Responses;

public class UpdateUserActiveExtensionsResponse
{
    /// <summary>
    /// <para>The extensions that the broadcaster updated.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserActiveExtension>? Data { get; init; }
}