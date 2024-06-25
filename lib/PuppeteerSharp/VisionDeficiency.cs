using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp
{
    /// <summary>
    /// Types of vision deficiency to emulate using <see cref="IPage.EmulateVisionDeficiencyAsync(VisionDeficiency)"/>.
    /// </summary>
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    public enum VisionDeficiency
    {
        /// <summary>
        /// None.
        /// </summary>
        None,

        /// <summary>
        /// Achromatopsia.
        /// </summary>
        Achromatopsia,

        /// <summary>
        /// BlurredVision.
        /// </summary>
        BlurredVision,

        /// <summary>
        /// Deuteranopia.
        /// </summary>
        Deuteranopia,

        /// <summary>
        /// Protanopia.
        /// </summary>
        Protanopia,

        /// <summary>
        /// Tritanopia.
        /// </summary>
        Tritanopia,
    }
}
