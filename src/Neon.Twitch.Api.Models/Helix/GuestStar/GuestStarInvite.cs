using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.GuestStar;

public class GuestStarInvite
{
    /// <summary>
    /// <para>Twitch User ID corresponding to the invited guest</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>Timestamp when this user was invited to the session.</para>
    /// </summary>
    [JsonPropertyName("invited_at")]
    public string? InvitedAt { get; init; }
    /// <summary>
    /// <para>Status representing the invited user’s join state. Can be one of the following: </para>
    /// <para>INVITED: The user has been invited to the session but has not acknowledged it.</para>
    /// <para>ACCEPTED: The invited user has acknowledged the invite and joined the waiting room, but may still be setting up their media devices or otherwise preparing to join the call.</para>
    /// <para>READY: The invited user has signaled they are ready to join the call from the waiting room.</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>Flag signaling that the invited user has chosen to disable their local video device. The user has hidden themselves, but they may choose to reveal their video feed upon joining the session.</para>
    /// </summary>
    [JsonPropertyName("is_video_enabled")]
    public bool? IsVideoEnabled { get; init; }
    /// <summary>
    /// <para>Flag signaling that the invited user has chosen to disable their local audio device. The user has muted themselves, but they may choose to unmute their audio feed upon joining the session.</para>
    /// </summary>
    [JsonPropertyName("is_audio_enabled")]
    public bool? IsAudioEnabled { get; init; }
    /// <summary>
    /// <para>Flag signaling that the invited user has a video device available for sharing.</para>
    /// </summary>
    [JsonPropertyName("is_video_available")]
    public bool? IsVideoAvailable { get; init; }
    /// <summary>
    /// <para>Flag signaling that the invited user has an audio device available for sharing.</para>
    /// </summary>
    [JsonPropertyName("is_audio_available")]
    public bool? IsAudioAvailable { get; init; }
}