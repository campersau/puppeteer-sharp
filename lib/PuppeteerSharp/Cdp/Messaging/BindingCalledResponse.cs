using System.Text.Json;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.Cdp.Messaging
{
    internal class BindingCalledResponse
    {
        private string _payloadJson;

        public int ExecutionContextId { get; set; }

        public BindingCalledResponsePayload BindingPayload { get; set; }

        public string Payload
        {
            get => _payloadJson;
            set
            {
                _payloadJson = value;
                BindingPayload = JsonSerializer.Deserialize<BindingCalledResponsePayload>(_payloadJson, JsonHelper.DefaultJsonSerializerOptions);
                BindingPayload.JsonObject = JsonSerializer.Deserialize<JsonElement>(_payloadJson);
            }
        }

        internal class BindingCalledResponsePayload
        {
            public string Type { get; set; }

            public string Name { get; set; }

            public JsonElement[] Args { get; set; }

            public int Seq { get; set; }

            public JsonElement JsonObject { get; set; }

            public bool IsTrivial { get; set; }
        }
    }
}
