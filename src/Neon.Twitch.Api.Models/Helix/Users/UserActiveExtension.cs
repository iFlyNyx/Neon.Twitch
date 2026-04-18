using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Users;

public class UserActiveExtension
{
    /// <summary>
    /// <para>A dictionary that contains the data for a panel extension. The dictionary’s key is a sequential number beginning with 1. The following fields contain the panel’s data for each key.</para>
    /// </summary>
    [JsonPropertyName("panel")]
    public Dictionary<string, UserPanel>? Panels { get; init; }
    /// <summary>
    /// <para>A dictionary that contains the data for a video-overlay extension. The dictionary’s key is a sequential number beginning with 1. The following fields contain the overlay’s data for each key.</para>
    /// </summary>
    [JsonPropertyName("overlay")]
    public Dictionary<string, UserOverlay>? Overlays { get; init; }
    /// <summary>
    /// <para>A dictionary that contains the data for a video-component extension. The dictionary’s key is a sequential number beginning with 1. The following fields contain the component’s data for each key.</para>
    /// </summary>
    [JsonPropertyName("component")]
    public Dictionary<string, UserComponent>? Components { get; init; }
}