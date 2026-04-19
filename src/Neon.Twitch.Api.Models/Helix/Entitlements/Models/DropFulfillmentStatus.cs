using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Entitlements.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum DropFulfillmentStatus
{
    CLAIMED,
    FULFILLED
}