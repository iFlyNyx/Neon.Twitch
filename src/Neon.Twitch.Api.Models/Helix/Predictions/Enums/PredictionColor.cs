using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Predictions.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum PredictionColor
{
    [JsonStringEnumMemberName("BLUE")]
    Blue,
    [JsonStringEnumMemberName("PINK")]
    Pink
}