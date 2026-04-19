using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Models;

public class UnbanRequest
{
    /// <summary>
    /// <para>Unban request ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>User ID of broadcaster whose channel is receiving the unban request.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The broadcaster's display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string? BroadcasterName { get; init; }
    /// <summary>
    /// <para>The broadcaster's login name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string? BroadcasterLogin { get; init; }
    /// <summary>
    /// <para>User ID of moderator who approved/denied the request.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; init; }
    /// <summary>
    /// <para>The moderator's login name.</para>
    /// </summary>
    [JsonPropertyName("moderator_login")]
    public string? ModeratorLogin { get; init; }
    /// <summary>
    /// <para>The moderator's display name.</para>
    /// </summary>
    [JsonPropertyName("moderator_name")]
    public string? ModeratorName { get; init; }
    /// <summary>
    /// <para>User ID of the requestor who is asking for an unban.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId  { get; init; }
    /// <summary>
    /// <para>The user's login name.</para>
    /// </summary>
    [JsonPropertyName("user_login")]
    public string? UserLogin { get; init; }
    /// <summary>
    /// <para>The user's display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>Text of the request from the requesting user.</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; init; }
    /// <summary>
    /// <para>Status of the request. One of:</para>
    /// <para>pending | approved | denied | acknowledged | canceled</para>
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; init; }
    /// <summary>
    /// <para>Timestamp of when the unban request was created.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
    /// <summary>
    /// <para>Timestamp of when moderator/broadcaster approved or denied the request.</para>
    /// </summary>
    [JsonPropertyName("resolved_at")]
    public string? ResolvedAt { get; init; }
    /// <summary>
    /// <para>Text input by the resolver (moderator) of the unban. request</para>
    /// </summary>
    [JsonPropertyName("resolution_text")]
    public string? ResolutionText { get; init; }
}