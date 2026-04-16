using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Conduits;

public class ConduitError
{
    /// <summary>
    /// <para>Shard ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The error that occurred while updating the shard. Possible errors:</para>
    /// <para>The length of the string in the secret field is not valid.</para>
    /// <para>The URL in the transport's callback field is not valid. The URL must use the HTTPS protocol and the 443 port number.</para>
    /// <para>The value specified in the method field is not valid.</para>
    /// <para>The callback field is required if you specify the webhook transport method.</para>
    /// <para>The session_id field is required if you specify the WebSocket transport method.</para>
    /// <para>The websocket session is not connected.</para>
    /// <para>The shard id is outside of the conduit’s range.</para>
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    /// <summary>
    /// <para>Error codes used to represent a specific error condition while attempting to update shards.</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}