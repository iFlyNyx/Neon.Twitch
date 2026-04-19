using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class Mobile
{
    /// <summary>
    /// <para>The HTML file that is shown to viewers on mobile devices. This page is presented to viewers as a panel behind the chat area of the mobile app.</para>
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string? ViewerUrl { get; init; }
}