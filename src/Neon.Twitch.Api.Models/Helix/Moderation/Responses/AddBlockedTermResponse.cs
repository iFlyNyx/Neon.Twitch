using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Moderation.Models;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Responses;

public class AddBlockedTermResponse
{
    /// <summary>
    /// <para>A list that contains the single blocked term that the broadcaster added.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<BlockedTerm>? Data { get; init; }
}