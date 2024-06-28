using System.Text.Json.Serialization;

namespace PuppeteerSharp.Cdp.Messaging;

/// <summary>
/// Navigation types.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NavigationType
{
    /// <summary>
    /// Normal navigation.
    /// </summary>
    Navigation,

    /// <summary>
    /// Back forward cache restore.
    /// </summary>
    BackForwardCacheRestore,
}
