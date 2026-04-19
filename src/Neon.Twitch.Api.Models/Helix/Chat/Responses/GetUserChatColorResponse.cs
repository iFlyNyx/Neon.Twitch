using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Chat.Models;

namespace Neon.Twitch.Api.Models.Helix.Chat.Responses;

public class GetUserChatColorResponse
{
    /// <summary>
    /// <para>The list of users and the color code they use for their name.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserChatColor>? Data { get; init; }
}