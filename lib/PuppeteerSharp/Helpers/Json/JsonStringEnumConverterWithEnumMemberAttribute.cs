using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PuppeteerSharp.Helpers.Json;

// https://github.com/dotnet/runtime/issues/74385#issuecomment-1705083109
internal class JsonStringEnumConverterWithEnumMemberAttribute<TEnum> : JsonConverterFactory
{
    private static readonly JsonStringEnumConverter _jsonStringEnumConverter = new JsonStringEnumConverter(ResolveNamingPolicy());

    public override bool CanConvert(Type typeToConvert)
        => typeToConvert.IsEnum;

    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        => _jsonStringEnumConverter.CreateConverter(typeToConvert, options);

    private static JsonNamingPolicy ResolveNamingPolicy()
    {
        var map = typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static)
            .Select(f => (f.Name, AttributeName: f.GetCustomAttribute<EnumMemberAttribute>()?.Value))
            .Where(pair => pair.AttributeName != null)
            .ToDictionary(kv => kv.Name, kv => kv.AttributeName);

        return map.Count > 0 ? new EnumMemberNamingPolicy(map) : JsonNamingPolicy.CamelCase;
    }

    private sealed class EnumMemberNamingPolicy(Dictionary<string, string> map) : JsonNamingPolicy
    {
        public override string ConvertName(string name)
            => map.TryGetValue(name, out var newName) ? newName : CamelCase.ConvertName(name);
    }
}
