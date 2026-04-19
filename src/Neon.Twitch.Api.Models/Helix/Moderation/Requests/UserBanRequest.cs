using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class UserBanRequest
{
    /// <summary>
    /// <para>The ID of the user to ban or put in a timeout.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    [Required]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>To ban a user indefinitely, don’t include this field.</para>
    /// <para>To put a user in a timeout, include this field and specify the timeout period, in seconds. The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).</para>
    /// <para>To end a user’s timeout early, set this field to 1, or use the <see href="https://dev.twitch.tv/docs/api/reference/#unban-user">Unban user</see> endpoint.</para>
    /// </summary>
    [JsonPropertyName("duration")]
    public int? Duration { get; set; }
    /// <summary>
    /// <para>The reason the you’re banning the user or putting them in a timeout. The text is user defined and is limited to a maximum of 500 characters.</para>
    /// </summary>
    [JsonPropertyName("reason")]
    [MaxLength(500)]
    public string? Reason { get; set; }
}