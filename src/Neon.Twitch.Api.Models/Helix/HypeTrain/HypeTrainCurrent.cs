using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain;

public class HypeTrainCurrent
{
    /// <summary>
    /// <para>The Hype Train ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The broadcaster ID.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_id")]
    public string? BroadcasterUserId { get; set; }
    /// <summary>
    /// <para>The broadcaster login.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_login")]
    public string? BroadcasterUserLogin { get; set; }
    /// <summary>
    /// <para>The broadcaster display name.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_user_name")]
    public string? BroadcasterUserName { get; set; }
    /// <summary>
    /// <para>The current level of the Hype Train.</para>
    /// </summary>
    [JsonPropertyName("level")]
    public int? Level { get; set; }
    /// <summary>
    /// <para>Total points contributed to the Hype Train.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }
    /// <summary>
    /// <para>The number of points contributed to the Hype Train at the current level.</para>
    /// </summary>
    [JsonPropertyName("progress")]
    public int? Progress { get; set; }
    /// <summary>
    /// <para>The number of points required to reach the next level.</para>
    /// </summary>
    [JsonPropertyName("goal")]
    public int? Goal { get; set; }
    /// <summary>
    /// <para>The contributors with the most points contributed.</para>
    /// </summary>
    [JsonPropertyName("top_contributions")]
    public List<HypeTrainContributor>? TopContributions { get; set; }
    /// <summary>
    /// <para>A list containing the broadcasters participating in the shared Hype Train. Null if the Hype Train is not shared.</para>
    /// </summary>
    [JsonPropertyName("shared_train_participants")]
    public List<SharedTrainParticipant>? SharedTrainParticipants { get; set; }
    /// <summary>
    /// <para>The time when the Hype Train started.</para>
    /// </summary>
    [JsonPropertyName("started_at")]
    public string? StartedAt { get; set; }
    /// <summary>
    /// <para>The time when the Hype Train expires. The expiration is extended when the Hype Train reaches a new level.</para>
    /// </summary>
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }
    /// <summary>
    /// <para>The type of the Hype Train. Possible values are: </para>
    /// <para>treasure | golden_kappa | regular</para>
    /// <para><see href="https://help.twitch.tv/s/article/hype-train-guide#special">Learn More</see></para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// <para>Indicates if the Hype Train is shared. When true, shared_train_participants will contain the list of broadcasters the train is shared with.</para>
    /// </summary>
    [JsonPropertyName("is_shared_train")]
    public bool? IsSharedTrain { get; set; }
}