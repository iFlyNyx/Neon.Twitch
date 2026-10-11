using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Enums;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

internal class AddSuspiciousUserStatusRequest
{
    /// <summary>
    /// <para>The ID of the user being given the suspicious status.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The type of suspicious status. Possible values are: ACTIVE_MONITORING | RESTRICTED</para>
    /// </summary>
    [JsonPropertyName("status")]
    public SuspiciousUserStatus? Status { get; init; }
}