namespace ExampleColorPlugin
{
    internal static class Utils
    {
        // Converts RGB values to HEX string
        internal static string RGB2HEX(byte red, byte green, byte blue)
        {
            return $"#{red:X2}{green:X2}{blue:X2}";
        }
    }
}
