using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class AddSuspiciousUserStatusRequest
{
    /// <summary>
    /// <para>The ID of the user being given the suspicious status.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>The type of suspicious status. Possible values are: ACTIVE_MONITORING | RESTRICTED</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}