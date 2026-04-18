using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Tags;

public class GetStreamTagsResponse
{
    /// <summary>
    /// <para>The list of stream tags. The list is empty if the broadcaster or Twitch hasn’t added tags to the broadcaster’s channel.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<StreamTag>? Data { get; set; }
}