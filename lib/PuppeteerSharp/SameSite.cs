using System.Text.Json.Serialization;

namespace PuppeteerSharp
{
    /// <summary>
    /// SameSite values in cookies.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SameSite
    {
        /// <summary>
        /// None.
        /// </summary>
        None,

        /// <summary>
        /// Strict.
        /// </summary>
        Strict,

        /// <summary>
        /// Lax.
        /// </summary>
        Lax,

        /// <summary>
        /// Extended.
        /// </summary>
        Extended,
    }
}
