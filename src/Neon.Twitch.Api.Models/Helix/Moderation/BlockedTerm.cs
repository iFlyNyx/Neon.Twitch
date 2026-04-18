using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class BlockedTerm
{
    /// <summary>
    /// <para>The broadcaster that owns the list of blocked terms.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The moderator that blocked the word or phrase from being used in the broadcaster’s chat room.</para>
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string? ModeratorId { get; set; }
    /// <summary>
    /// <para>An ID that identifies this blocked term.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The blocked word or phrase.</para>
    /// </summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that the term was blocked.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that the term was updated.</para>
    /// <para>When the term is added, this timestamp is the same as created_at. The timestamp changes as AutoMod continues to deny the term.</para>
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }
    /// <summary>
    /// <para>The UTC date and time (in RFC3339 format) that the blocked term is set to expire. After the block expires, users may use the term in the broadcaster’s chat room.</para>
    /// <para>This field is null if the term was added manually or was permanently blocked by AutoMod.</para>
    /// </summary>
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }
}