using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CustomRewardRedemptionStatus
{
    CANCELED,
    FULFILLED
}