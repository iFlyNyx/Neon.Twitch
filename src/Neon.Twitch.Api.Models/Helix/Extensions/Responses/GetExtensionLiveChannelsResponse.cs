using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Extensions.Models;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Responses;

public class GetExtensionLiveChannelsResponse
{
    /// <summary>
    /// <para>The list of broadcasters that are streaming live and that have installed or activated the extension.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<ExtensionLiveChannel>? Data { get; init; }
    /// <summary>
    /// <para>This field contains the cursor used to page through the results. The field is empty if there are no more pages left to page through. Note that this field is a string compared to other endpoints that use a Pagination object.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public string? Pagination { get; init; }
}