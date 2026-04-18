using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Channels;

public class ChannelEditor
{
    /// <summary>
    /// <para>An ID that uniquely identifies a user with editor permissions.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    public string? UserId { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("user_name")]
    public string? UserName { get; init; }
    /// <summary>
    /// <para>The date and time, in RFC3339 format, when the user became one of the broadcaster’s editors.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
}