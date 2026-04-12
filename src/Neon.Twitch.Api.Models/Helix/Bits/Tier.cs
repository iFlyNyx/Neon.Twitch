using System.Text.Json.Serialization;

namespace Neon.Twitch.Api.Models.Helix.Bits;

public class Tier
{
    /// <summary>
    /// <para>The minimum number of Bits that you must cheer at this tier level. The maximum number of Bits that you can cheer at this level is determined by the required minimum Bits of the next tier level minus 1. For example, if min_bits is 1 and min_bits for the next tier is 100, the Bits range for this tier level is 1 through 99. The minimum Bits value of the last tier is the maximum number of Bits you can cheer using this Cheermote. For example, 10000.</para>
    /// </summary>
    [JsonPropertyName("min_bits")]
    public int? MinBits { get; set; }
    /// <summary>
    /// <para>The tier level. Possible tiers are:</para>
    /// <para>1|100|500|1000|5000|10000|100000</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    /// <summary>
    /// <para>The hex code of the color associated with this tier level (for example, #979797).</para>
    /// </summary>
    [JsonPropertyName("color")]
    public string? Color { get; set; }
    /// <summary>
    /// <para>The animated and static image sets for the Cheermote. The dictionary of images is organized by theme, format, and size. The theme keys are dark and light. Each theme is a dictionary of formats: animated and static. Each format is a dictionary of sizes: 1, 1.5, 2, 3, and 4. The value of each size contains the URL to the image.</para>
    /// </summary>
    [JsonPropertyName("images")]
    public Images? Images { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether users can cheer at this tier level.</para>
    /// </summary>
    [JsonPropertyName("can_cheer")]
    public bool? CanCheer { get; set; }
    /// <summary>
    /// <para>A Boolean value that determines whether this tier level is shown in the Bits card. Is true if this tier level is shown in the Bits card.</para>
    /// </summary>
    [JsonPropertyName("show_in_bits_card")]
    public bool? ShowInBitsCard { get; set; }
}