using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class UnbanRequest
{
    /// <summary>
    /// <para>Unban request ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>User ID of broadcaster whose channel is receiving the unban request.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The broadcaster's display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; set; }
    /// <summary>
    /// <para>The broadcaster's login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; set; }
    /// <summary>
    /// <para>User ID of moderator who approved/denied the request.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; set; }
    /// <summary>
    /// <para>The moderator's login name.</para>
    /// </summary>
    [JsonPropertyName("moderator_login")]
    public string? ModeratorLogin { get; set; }
    /// <summary>
    /// <para>The moderator's display name.</para>
    /// </summary>
    [JsonPropertyName("moderator_name")]
    public string? ModeratorName { get; set; }
    /// <summary>
    /// <para>User ID of the requestor who is asking for an unban.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId  { get; set; }
    /// <summary>
    /// <para>The user's login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; set; }
    /// <summary>
    /// <para>The user's display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; set; }
    /// <summary>
    /// <para>Text of the request from the requesting user.</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    /// <summary>
    /// <para>Status of the request. One of:</para>
    /// <para>pending | approved | denied | acknowledged | canceled</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
    /// <summary>
    /// <para>Timestamp of when the unban request was created.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>Timestamp of when moderator/broadcaster approved or denied the request.</para>
    /// </summary>
    [JsonPropertyName("resolved_at")]
    public string? ResolvedAt { get; set; }
    /// <summary>
    /// <para>Text input by the resolver (moderator) of the unban. request</para>
    /// </summary>
    [JsonPropertyName("resolution_text")]
    public string? ResolutionText { get; set; }
}