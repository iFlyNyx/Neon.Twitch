using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads;

public class StartCommercialResponse
{
    /// <summary>
    /// <para>An array that contains a single object with the status of your start commercial request.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StartCommercial>? Data { get; init; }
}