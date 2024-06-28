using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.Cdp.Messaging
{
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    internal enum FileChooserAction
    {
        /// <summary>
        /// Accept.
        /// </summary>
        Accept,

        /// <summary>
        /// Fallback.
        /// </summary>
        Fallback,

        /// <summary>
        /// Cancel.
        /// </summary>
        Cancel,
    }
}
