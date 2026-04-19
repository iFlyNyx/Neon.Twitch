using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Ads.Requests;

public class StartCommercialRequest
{
    /// <summary>
    /// <para>The ID of the partner or affiliate broadcaster that wants to run the commercial. This ID must match the user ID found in the OAuth token.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    [Required]
    public string? BroadcasterId { get; set; }
    /// <summary>
    /// <para>The length of the commercial to run, in seconds. Twitch tries to serve a commercial that’s the requested length, but it may be shorter or longer. The maximum length you should request is 180 seconds.</para>
    /// </summary>
    [JsonPropertyName("length")]
    [Required]
    public int? Length { get; set; }
}