using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Polls;

public class CreatePollResponse
{
    /// <summary>
    /// <para>A list that contains the single poll that you created.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Poll>? Data { get; set; }
}