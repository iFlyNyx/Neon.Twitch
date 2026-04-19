using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Channels.Models;

namespace Neon.Twitch.Api.Models.Helix.Channels.Responses;

public class ChannelInformationResponse
{
    /// <summary>
    /// <para>A list that contains information about the specified channels. The list is empty if the specified channels weren’t found.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ChannelInformation>? Data { get; init; }
}