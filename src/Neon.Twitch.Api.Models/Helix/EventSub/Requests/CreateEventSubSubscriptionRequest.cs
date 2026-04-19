using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.EventSub.Requests;

public class CreateEventSubSubscriptionRequest
{
    /// <summary>
    /// <para>The type of subscription to create. For a list of subscriptions that you can create, see <see href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types#subscription-types">Subscription Types</see>. Set this field to the value in the Name column of the Subscription Types table.</para>
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    /// <summary>
    /// <para>The version number that identifies the definition of the subscription type that you want the response to use.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
    /// <summary>
    /// <para>A JSON object that contains the parameter values that are specific to the specified subscription type. For the object’s required and optional fields, see the subscription type’s documentation.</para>
    /// </summary>
    [JsonPropertyName("condition")]
    public Dictionary<string, string>? Conditions { get; set; }
    /// <summary>
    /// <para>The transport details that you want Twitch to use when sending you notifications.</para>
    /// </summary>
    [JsonPropertyName("transport")]
    public CreateTransportRequest? Transport { get; set; }
}