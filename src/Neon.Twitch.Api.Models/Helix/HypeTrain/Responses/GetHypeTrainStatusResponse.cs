using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.HypeTrain.Models;

namespace Neon.Twitch.Api.Models.Helix.HypeTrain.Responses;

internal class GetHypeTrainStatusResponse
{
    /// <summary>
    /// <para>A list that contains information related to the channel’s Hype Train.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<HypeTrainStatus>? Data { get; init; }
}