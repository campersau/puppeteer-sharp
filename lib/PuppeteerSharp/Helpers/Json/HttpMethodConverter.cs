using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PuppeteerSharp.Helpers.Json
{
    internal class HttpMethodConverter : JsonConverter<HttpMethod>
    {
        public override HttpMethod Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => new(reader.GetString());

        public override void Write(Utf8JsonWriter writer, HttpMethod value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.Method);
    }
}
