using System.Text.Json.Serialization;
using System.Text.Json;

namespace PCKonfiguratorBackend
{
    public static class Helper
    {
        public static string ToJson<T>(this T obj)
        {
            var options = new JsonSerializerOptions
            {
                Converters = { new JsonStringEnumConverter() },
                WriteIndented = true 
            };

            return JsonSerializer.Serialize(obj, options);
        }
    }
}
