using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.Cdp.Messaging
{
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    internal enum DragEventType
    {
        /// <summary>
        /// Drag event.
        /// </summary>
        DragEnter,

        /// <summary>
        /// Drag over.
        /// </summary>
        DragOver,

        /// <summary>
        /// Drop.
        /// </summary>
        Drop,
    }
}
