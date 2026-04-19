using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Streams.Requests;

public class CreateStreamMarkerRequest
{
    /// <summary>
    /// <para>The ID of the broadcaster that’s streaming content. This ID must match the user ID in the access token or the user in the access token must be one of the broadcaster’s editors.</para>
    /// </summary>
    [JsonPropertyName("user_id")]
    [Required]
    public string? UserId { get; set; }
    /// <summary>
    /// <para>A short description of the marker to help the user remember why they marked the location. The maximum length of the description is 140 characters.</para>
    /// </summary>
    [JsonPropertyName("description")]
    [MaxLength(140)]
    public string? Description { get; set; }
}