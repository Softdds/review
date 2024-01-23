using System.Diagnostics.Contracts;

namespace DDS.FireblocksApi.Utils
{
    public static class HexConverter
    {
        public static decimal ParseFromHex(string hex)
        {
            if (string.IsNullOrWhiteSpace(hex))
                throw new ArgumentException("Hex string must not be empty", nameof(hex));

            if (hex.Length < 2)
                throw new FormatException($"Hex string '{hex}' has invalid length");

            if (!(hex[0] == '0' && hex[1] == 'x'))
                throw new FormatException($"Hex string '{hex}' must start with '0x'");

            return InternalParseFromHex(hex);
        }

        private static decimal InternalParseFromHex(string hex)
        {
            decimal accumulator = 0;

            int power = 0;

            for (int i = hex.Length - 1; i >= 2; i -= 1)
            {
                var @byte = GetValue(hex[i]);

                ulong powered = 1;

                for (int j = 0; j < power; j++)
                    powered *= 16;

                power++;

                accumulator += @byte * powered;
            }

            Contract.Assert(accumulator > 0);

            return accumulator;
        }

        private static byte GetValue(char symbol)
        {
            return symbol switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                'A' => 10,
                'a' => 10,
                'B' => 11,
                'b' => 11,
                'C' => 12,
                'c' => 12,
                'D' => 13,
                'd' => 13,
                'E' => 14,
                'e' => 14,
                'F' => 15,
                'f' => 15,
                _ => throw new FormatException($"Hex contains invalid character '{symbol}'")
            };
        }
    }
}
