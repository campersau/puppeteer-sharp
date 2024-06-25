using System.Text.Json.Serialization;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp
{
    [JsonConverter(typeof(JsonStringCamelCaseEnumConverter))]
    internal enum DOMWorldType
    {
        /// <summary>
        /// Other type.
        /// </summary>
        Other,

        /// <summary>
        /// Isolated type.
        /// </summary>
        Isolated,

        /// <summary>
        /// Default type.
        /// </summary>
        Default,
    }
}
