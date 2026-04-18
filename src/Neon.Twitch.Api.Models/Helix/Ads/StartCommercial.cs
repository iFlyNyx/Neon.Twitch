using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads;

public class StartCommercial
{
    /// <summary>
    /// <para>The length of the commercial you requested. If you request a commercial that’s longer than 180 seconds, the API uses 180 seconds.</para>
    /// </summary>
    [JsonPropertyName("length")]
    public int? Length { get; init; }
    /// <summary>
    /// <para>A message that indicates whether Twitch was able to serve an ad.</para>
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; init; }
    /// <summary>
    /// <para>The number of seconds you must wait before running another commercial.</para>
    /// </summary>
    [JsonPropertyName("retry_after")]
    public int? RetryAfter { get; init; }
}