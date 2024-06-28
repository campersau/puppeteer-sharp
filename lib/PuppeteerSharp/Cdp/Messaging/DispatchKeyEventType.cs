using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.Cdp.Messaging
{
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    internal enum DispatchKeyEventType
    {
        /// <summary>
        /// Key down.
        /// </summary>
        KeyDown,

        /// <summary>
        /// Raw key down.
        /// </summary>
        RawKeyDown,

        /// <summary>
        /// Key up.
        /// </summary>
        KeyUp,
    }
}
