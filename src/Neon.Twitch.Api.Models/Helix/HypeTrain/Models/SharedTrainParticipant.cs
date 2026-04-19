using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain.Models;

public class SharedTrainParticipant
{
    /// <summary>
    /// <para>The broadcaster ID.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_id")]
    public string? BroadcasterUserId { get; init; }
    /// <summary>
    /// <para>The broadcaster login.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_login")]
    public string? BroadcasterUserLogin { get; init; }
    /// <summary>
    /// <para>The broadcaster display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_name")]
    public string? BroadcasterUserName { get; init; }
}