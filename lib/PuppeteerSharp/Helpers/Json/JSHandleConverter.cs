using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PuppeteerSharp.Helpers.Json
{
    /// <summary>
    /// JSHandleConverter will throw an exception if a JSHandle object is trying to be serialized.
    /// </summary>
    internal class JSHandleConverter : JsonConverter<IJSHandle>
    {
        public override bool CanConvert(Type typeToConvert) => typeof(IJSHandle).IsAssignableFrom(typeToConvert);

        public override IJSHandle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => default;

        public override void Write(Utf8JsonWriter writer, IJSHandle value, JsonSerializerOptions options)
            => throw new EvaluationFailedException("Unable to make function call. Are you passing a nested JSHandle?");
    }
}
