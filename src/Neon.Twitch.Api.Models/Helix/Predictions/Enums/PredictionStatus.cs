using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PredictionStatus
{
    [JsonStringEnumMemberName("ACTIVE")]
    Active,
    [JsonStringEnumMemberName("CANCELED")]
    Canceled,
    [JsonStringEnumMemberName("LOCKED")]
    Locked,
    [JsonStringEnumMemberName("RESOLVED")]
    Resolved
}