using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Schedule;

public class Category
{
    /// <summary>
    /// <para>An ID that identifies the category that best represents the content that the broadcaster plans to stream. For example, the game’s ID if the broadcaster will play a game or the Just Chatting ID if the broadcaster will host a talk show.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The name of the category. For example, the game’s title if the broadcaster will playing a game or Just Chatting if the broadcaster will host a talk show.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}