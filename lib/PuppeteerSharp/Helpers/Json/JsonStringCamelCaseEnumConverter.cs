using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PuppeteerSharp.Helpers.Json;

internal class JsonStringCamelCaseEnumConverter : JsonConverterFactory
{
    private static readonly JsonStringEnumConverter _jsonStringEnumConverter = new JsonStringEnumConverter(JsonNamingPolicy.CamelCase);

    public override bool CanConvert(Type typeToConvert)
        => typeToConvert.IsEnum;

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        => _jsonStringEnumConverter.CreateConverter(typeToConvert, options);
}
