using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.Input
{
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    internal enum PointerType
    {
        /// <summary>
        /// Mouse.
        /// </summary>
        Mouse,

        /// <summary>
        /// Pen.
        /// </summary>
        Pen,
    }
}
