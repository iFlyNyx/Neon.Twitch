using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Goals.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
internal enum GoalType
{
    [JsonStringEnumMemberName("follower")]
    Follower,
    [JsonStringEnumMemberName("subscription")]
    Subscription,
    [JsonStringEnumMemberName("subscription_count")]
    SubscriptionCount,
    [JsonStringEnumMemberName("new_subscription")]
    NewSubscription,
    [JsonStringEnumMemberName("new_subscription_count")]
    NewSubscriptionCount,
    [JsonStringEnumMemberName("new_bit")]
    NewBit,
    [JsonStringEnumMemberName("new_cheerer")]
    NewCheerer
}