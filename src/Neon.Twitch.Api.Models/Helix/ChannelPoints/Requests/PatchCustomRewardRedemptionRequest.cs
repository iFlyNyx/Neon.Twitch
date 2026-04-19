using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Neon.Twitch.Api.Models.Helix.ChannelPoints.Models;

namespace Neon.Twitch.Api.Models.Helix.ChannelPoints.Requests;

public class PatchCustomRewardRedemptionRequest
{
    /// <summary>
    /// <para>The status to set the redemption to. Possible values are:</para>
    /// <para>CANCELED | FULFILLED</para>
    /// <para>Setting the status to CANCELED refunds the user’s channel points.</para>
    /// </summary>
    [JsonPropertyName("status")]
    [Required]
    public CustomRewardRedemptionStatus? Status { get; set; }
}