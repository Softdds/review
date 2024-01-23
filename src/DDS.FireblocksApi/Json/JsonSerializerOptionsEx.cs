using System.Text.Json;
using System.Text.Json.Serialization;
using DDS.FireblocksApi.Json.Converters;

namespace DDS.FireblocksApi.Json
{
    public static class JsonSerializerOptionsEx
    {
        public static readonly JsonSerializerOptions DefaultOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            WriteIndented = false,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            Converters =
            {
                new JsonStringEnumConverter(),
                new DecimalConverter()
            },
        };
    }
}
