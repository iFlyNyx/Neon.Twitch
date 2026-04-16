using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain;

public class GetHypeTrainStatusResponse
{
    /// <summary>
    /// <para>A list that contains information related to the channel’s Hype Train.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<HypeTrainStatus>? Data { get; set; }
}