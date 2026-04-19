using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Extensions.Models;

public class Extension
{
    /// <summary>
    /// <para>The name of the user or organization that owns the extension.</para>
    /// </summary>
    [JsonPropertyName("author_name")]
    public string? AuthorName { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension has features that use Bits. Is true if the extension has features that use Bits.</para>
    /// </summary>
    [JsonPropertyName("bits_enabled")]
    public bool? BitsEnabled { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether a user can install the extension on their channel. Is true if a user can install the extension.</para>
    /// <para>Typically, this is set to false if the extension is currently in testing mode and requires users to be allowlisted (the allowlist is configured on Twitch’s developer site under the Extensions -> Extension -> Version -> Access).</para>
    /// </summary>
    [JsonPropertyName("can_install")]
    public bool? CanInstall { get; init; }
    /// <summary>
    /// <para>The location of where the extension’s configuration is stored. Possible values are:</para>
    /// <para>hosted — The Extensions Configuration Service hosts the configuration.</para>
    /// <para>custom — The Extension Backend Service (EBS) hosts the configuration.</para>
    /// <para>none — The extension doesn't require configuration.</para>
    /// </summary>
    [JsonPropertyName("configuration_location")]
    public string? ConfigurationLocation { get; init; }
    /// <summary>
    /// <para>A longer description of the extension. It appears on the details page.</para>
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }
    /// <summary>
    /// <para>A URL to the extension’s Terms of Service.</para>
    /// </summary>
    [JsonPropertyName("eula_tos_url")]
    public string? EulaTosUrl { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension can communicate with the installed channel’s chat. Is true if the extension can communicate with the channel’s chat room.</para>
    /// </summary>
    [JsonPropertyName("has_chat_support")]
    public bool? HasChatSupport { get; init; }
    /// <summary>
    /// <para>A URL to the default icon that’s displayed in the Extensions directory.</para>
    /// </summary>
    [JsonPropertyName("icon_url")]
    public string? IconUrl { get; init; }
    /// <summary>
    /// <para>A dictionary that contains URLs to different sizes of the default icon. The dictionary’s key identifies the icon’s size (for example, 24x24), and the dictionary’s value contains the URL to the icon.</para>
    /// </summary>
    [JsonPropertyName("icon_urls")]
    public Dictionary<string, string>? IconUrls { get; init; }
    /// <summary>
    /// <para>The extension’s ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; init; }
    /// <summary>
    /// <para>The extension’s name.</para>
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
    /// <summary>
    /// <para>A URL to the extension’s privacy policy.</para>
    /// </summary>
    [JsonPropertyName("privacy_policy_url")]
    public string? PrivacyPolicyUrl { get; init; }
    /// <summary>
    /// <para>A Boolean value that determines whether the extension wants to explicitly ask viewers to link their Twitch identity.</para>
    /// </summary>
    [JsonPropertyName("request_identity_link")]
    public bool? RequestIdentityLink { get; init; }
    /// <summary>
    /// <para>A list of URLs to screenshots that are shown in the Extensions marketplace.</para>
    /// </summary>
    [JsonPropertyName("screenshot_urls")]
    public List<string>? ScreenshotUrls { get; init; }
    /// <summary>
    /// <para>The extension’s state. Possible values are:</para>
    /// <para>Approved | AssetsUploaded | Deleted | Deprecated | InReview | InTest | PendingAction | Rejected | Released</para>
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; init; }
    /// <summary>
    /// <para>Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. Possible values are:</para>
    /// <para>none — The extension can't view the user’s subscription level.</para>
    /// <para>optional — The extension can view the user’s subscription level.</para>
    /// </summary>
    [JsonPropertyName("subscriptions_support_level")]
    public string? SubscriptionsSupportLevel { get; init; }
    /// <summary>
    /// <para>A short description of the extension that streamers see when hovering over the discovery splash screen in the Extensions manager.</para>
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; init; }
    /// <summary>
    /// <para>The email address that users use to get support for the extension.</para>
    /// </summary>
    [JsonPropertyName("support_email")]
    public string? SupportEmail { get; init; }
    /// <summary>
    /// <para>The extension’s version number.</para>
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; init; }
    /// <summary>
    /// <para>A brief description displayed on the channel to explain how the extension works.</para>
    /// </summary>
    [JsonPropertyName("viewer_summary")]
    public string? ViewerSummary { get; init; }
    /// <summary>
    /// <para>Describes all views-related information such as how the extension is displayed on mobile devices.</para>
    /// </summary>
    [JsonPropertyName("views")]
    public ExtensionView? Views { get; init; }
    /// <summary>
    /// <para>Allowlisted configuration URLs for displaying the extension (the allowlist is configured on Twitch’s developer site under the Extensions -> Extension -> Version -> Capabilities).</para>
    /// </summary>
    [JsonPropertyName("allowlisted_config_urls")]
    public List<string>? AllowlistedConfigUrls { get; init; }
    /// <summary>
    /// <para>Allowlisted panel URLs for displaying the extension (the allowlist is configured on Twitch’s developer site under the Extensions -> Extension -> Version -> Capabilities).</para>
    /// </summary>
    [JsonPropertyName("allowlisted_panel_urls")]
    public List<string>? AllowlistedPanelUrls { get; init; }
}