using System.Text.RegularExpressions;

namespace Kaijinix.HLE.HOS.Applets.SoftwareKeyboard
{
    public static partial class NumericCharacterValidation
    {
        public static bool IsNumeric(char value)
        {
            Regex regex = NumericRegex();

            return regex.IsMatch(value.ToString());
        }

        [GeneratedRegex("[0-9]|.")]
        private static partial Regex NumericRegex();
    }
}
