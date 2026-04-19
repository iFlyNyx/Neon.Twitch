using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.Subscriptions.Models;

namespace Neon.Twitch.Api.Models.Helix.Subscriptions.Responses;

public class CheckUserSubscriptionResponse
{
    /// <summary>
    /// <para>A list that contains a single object with information about the user’s subscription.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public List<UserSubscription>? Data { get; init; }
}