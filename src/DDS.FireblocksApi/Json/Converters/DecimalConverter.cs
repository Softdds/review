using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using DDS.FireblocksApi.Utils;

namespace DDS.FireblocksApi.Json.Converters
{
    internal sealed class DecimalConverter : JsonConverter<decimal>
    {
        public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                return reader.GetDecimal();
            }

            if (options.NumberHandling.HasFlag(JsonNumberHandling.AllowReadingFromString))
            {
                if (reader.TokenType == JsonTokenType.String)
                {
                    var str = reader.GetString();

                    // hexadecimal string start with 0x
                    if (str.StartsWith("0x"))
                    {
                        return HexConverter.ParseFromHex(str);
                    }
                    else
                    {
                        return decimal.Parse(str);
                    }
                }
            }

            throw new JsonException($"Unable to convert value to decimal");
        }

        public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
        {
            if (options.NumberHandling.HasFlag(JsonNumberHandling.WriteAsString))
            {
                writer.WriteStringValue(value.ToString("G", CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNumberValue(value);
            }
        }
    }
}
