using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain;

public class SharedTrainParticipant
{
    /// <summary>
    /// <para>The broadcaster ID.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_id")]
    public string? BroadcasterUserId { get; set; }
    /// <summary>
    /// <para>The broadcaster login.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_login")]
    public string? BroadcasterUserLogin { get; set; }
    /// <summary>
    /// <para>The broadcaster display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_name")]
    public string? BroadcasterUserName { get; set; }
}