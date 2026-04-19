using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Polls.Models;

namespace Neon.Twitch.Api.Models.Helix.Polls.Responses;

public class EndPollsResponse
{
    /// <summary>
    /// <para>A list that contains the poll that you ended.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Poll>? Data { get; init; }
}