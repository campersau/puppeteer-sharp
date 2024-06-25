using System;
using System.Text.Json;

namespace PuppeteerSharp.Helpers.Json
{
    internal static class JsonHelper
    {
        public static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            IgnoreNullValues = true,
            Converters = { new JSHandleConverter(), },
        };

        public static T Deserialize<T>(this JsonElement jsonElement, JsonSerializerOptions jsonSerializerOptions = null)
            => jsonElement.ValueKind == JsonValueKind.Undefined ? default : JsonSerializer.Deserialize<T>(jsonElement.GetRawText(), jsonSerializerOptions);

        public static object Deserialize(this JsonElement jsonElement, Type returnType, JsonSerializerOptions jsonSerializerOptions = null)
            => jsonElement.ValueKind == JsonValueKind.Undefined ? default : JsonSerializer.Deserialize(jsonElement.GetRawText(), returnType, jsonSerializerOptions);

        public static object UnwrapJsonElement(object jsonElement)
        {
            if (jsonElement is not JsonElement element)
            {
                throw new InvalidOperationException("JsonElement expected");
            }

            return element.ValueKind switch
            {
                JsonValueKind.Undefined => null,
                JsonValueKind.Null => null,
                JsonValueKind.True => true,
                JsonValueKind.False => false,
                JsonValueKind.String => element.GetString(),
                JsonValueKind.Number => element.TryGetInt32(out var i) ? i : element.GetDouble(),
                _ => jsonElement,
            };
        }
    }
}
