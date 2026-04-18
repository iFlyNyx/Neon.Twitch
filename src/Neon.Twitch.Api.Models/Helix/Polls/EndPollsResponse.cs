using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls;

public class EndPollsResponse
{
    /// <summary>
    /// <para>A list that contains the poll that you ended.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Poll>? Data { get; set; }
}