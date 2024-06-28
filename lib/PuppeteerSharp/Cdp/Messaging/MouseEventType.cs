using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.Cdp.Messaging
{
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    internal enum MouseEventType
    {
        /// <summary>
        /// Mouse moved.
        /// </summary>
        MouseMoved,

        /// <summary>
        /// Mouse clicked.
        /// </summary>
        MousePressed,

        /// <summary>
        /// Mouse click released.
        /// </summary>
        MouseReleased,

        /// <summary>
        /// Mouse wheel.
        /// </summary>
        MouseWheel,
    }
}
