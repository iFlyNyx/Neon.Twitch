using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class User
{
    /// <summary>
    /// <para>An ID that identifies the user.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The user’s login name.</para>
    /// </summary>
    [JsonPropertyName("login")]
    public string? Login { get; init; }
    /// <summary>
    /// <para>The user’s display name.</para>
    /// </summary>
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }
    /// <summary>
    /// <para>The type of user. Possible values are: </para>
    /// <para>admin | global_mod | staff | "" (normal user)</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }
    /// <summary>
    /// <para>The type of broadcaster. Possible values are: </para>
    /// <para>affiliate | partner | "" (normal broadcaster)</para>
    /// </summary>
    [JsonPropertyName("broadcaster_type")]
    public string? BroadcasterType { get; init; }
    /// <summary>
    /// <para>The user’s description of their channel.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    /// <summary>
    /// <para>A URL to the user’s profile image.</para>
    /// </summary>
    [JsonPropertyName("profile_image_url")]
    public string? ProfileImageUrl { get; init; }
    /// <summary>
    /// <para>A URL to the user’s offline image.</para>
    /// </summary>
    [JsonPropertyName("offline_image_url")]
    public string? OfflineImageUrl { get; init; }
    /// <summary>
    /// <para>The number of times the user’s channel has been viewed.</para>
    /// <para> NOTE: This field has been deprecated (see <see href="https://discuss.dev.twitch.tv/t/get-users-api-endpoint-view-count-deprecation/37777">Get Users API endpoint – “view_count” deprecation</see>). Any data in this field is not valid and should not be used.</para>
    /// </summary>
    [JsonPropertyName("view_count")]
    [Obsolete("Deprecated data. Invalid, inaccurate, and not updated.")]
    public int? ViewCount { get; init; }
    /// <summary>
    /// <para>The user’s verified email address. The object includes this field only if the user access token includes the user:read:email scope.</para>
    /// <para>If the request contains more than one user, only the user associated with the access token that provided consent will include an email address — the email address for all other users will be empty.</para>
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; init; }
    /// <summary>
    /// <para>The UTC date and time that the user’s account was created. The timestamp is in RFC3339 format.</para>
    /// </summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; init; }
}