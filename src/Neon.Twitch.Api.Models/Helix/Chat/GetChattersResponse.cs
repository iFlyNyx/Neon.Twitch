using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Shared;

namespace Neon.Twitch.Api.Models.Helix.Chat;

public class GetChattersResponse
{
    /// <summary>
    /// <para>The list of users that are connected to the broadcaster’s chat room. The list is empty if no users are connected to the chat room.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<Chatter>? Data { get; init; }
    /// <summary>
    /// <para>Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.</para>
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination? Pagination { get; init; }
    /// <summary>
    /// <para>The total number of users that are connected to the broadcaster’s chat room. As you page through the list, the number of users may change as users join and leave the chat room.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int? Total { get; init; }
}