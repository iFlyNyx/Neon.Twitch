using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation;

public class GetBlockedTermsResponse
{
    /// <summary>
    /// <para>The list of blocked terms. The list is in descending order of when they were created (see the created_at timestamp).</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<BlockedTerm>? Data { get; set; }
}