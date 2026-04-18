using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Auth;

public class DeviceCodeAuthResponse
{
    /// <summary>
    /// <para>The identifier for a given user.</para>
    /// </summary>
    [JsonPropertyName("device_code")]
    public string? DeviceCode { get; init; }
    /// <summary>
    /// <para>Time until the code is no longer valid</para>
    /// </summary>
    [JsonPropertyName("expires_in")]
    public int? ExpiresIn { get; init; }
    /// <summary>
    /// <para>Time until another valid code can be requested</para>
    /// </summary>
    [JsonPropertyName("interval")]
    public int? Interval { get; init; }
    /// <summary>
    /// <para>The code that the user will use to authenticate</para>
    /// </summary>
    [JsonPropertyName("user_code")]
    public string? UserCode { get; init; }
    /// <summary>
    /// <para>The address you will send users to, to authenticate</para>
    /// </summary>
    [JsonPropertyName("verification_uri")]
    public string? VerificationUri { get; init; }
}