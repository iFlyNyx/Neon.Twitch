using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Shared;

/// <summary>
/// <para>The reporting window’s start and end dates, in RFC3339 format.</para>
/// </summary>
public class DateRange
{
    /// <summary>
    /// <para>The reporting window’s start date.</para>
    /// </summary>
    [JsonPropertyName("started_at")]
    public string? StartedAt { get; init; }
    /// <summary>
    /// <para>The reporting window’s end date.</para>
    /// </summary>
    [JsonPropertyName("ended_at")]
    public string? EndedAt { get; init; }
}