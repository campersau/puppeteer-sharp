using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using PuppeteerSharp.Helpers.Json;

namespace PuppeteerSharp.BrowserData
{
    internal class JsonUtils
    {
        public static async Task<T> GetAsync<T>(string url)
        {
            using var client = new HttpClient();
            var response = await client.GetStringAsync(url).ConfigureAwait(false);
            return JsonSerializer.Deserialize<T>(response, JsonHelper.DefaultJsonSerializerOptions);
        }

        internal static async Task<string> GetTextAsync(string url)
        {
            using var client = new HttpClient();
            return await client.GetStringAsync(url).ConfigureAwait(false);
        }
    }
}
