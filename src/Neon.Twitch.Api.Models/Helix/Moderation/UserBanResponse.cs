using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class UserBanResponse
{
    /// <summary>
    /// <para>A list that contains the user you successfully banned or put in a timeout.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserBan>? Data { get; set; }
}