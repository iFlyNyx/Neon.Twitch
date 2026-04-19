using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Polls.Models;

namespace Neon.Twitch.Api.Models.Helix.Polls.Responses;

public class CreatePollResponse
{
    /// <summary>
    /// <para>A list that contains the single poll that you created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Poll>? Data { get; init; }
}