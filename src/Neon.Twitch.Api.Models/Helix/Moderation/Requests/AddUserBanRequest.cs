using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Moderation.Requests;

public class AddUserBanRequest
{
    /// <summary>
    /// <para>Identifies the user and type of ban.</para>
    /// </summary>
    [JsonPropertyName("data")]
    [Required]
    public UserBanRequest? UserBanRequest { get; set; }
}