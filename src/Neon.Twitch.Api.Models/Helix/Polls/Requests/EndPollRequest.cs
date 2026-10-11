using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Polls.Enums;
using Neon.Twitch.Api.Models.Helix.Polls.Responses;

namespace Neon.Twitch.Api.Models.Helix.Polls.Requests;

internal class EndPollRequest
{
    /// <summary>
    /// <para>The ID of the broadcaster that’s running the poll. This ID must match the user ID in the user access token.</para>
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    [Required]
    public string? BroadcasterId { get; init; }
    /// <summary>
    /// <para>The ID of the poll to update.</para>
    /// </summary>
    [JsonPropertyName("id")]
    [Required]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The status to set the poll to. Possible case-sensitive values are:</para>
    /// <para>TERMINATED — Ends the poll before the poll is scheduled to end. The poll remains publicly visible.</para>
    /// <para>ARCHIVED — Ends the poll before the poll is scheduled to end, and then archives it so it's no longer publicly visible.</para>
    /// </summary>
    [JsonPropertyName("status")]
    [Required]
    public EndPollStatus? Status { get; init; }
}