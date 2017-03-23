namespace Methods.Common
{
    using System;

    public static class Converter
    {
        public static string DigitToWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException($"Incorrect digit value: {digit}");
            }
        }

        public static string NumberToString(double number, string format)
        {
            var result = string.Empty;

            if (format == "f")
            {
                result = string.Format("{0:f2}", number);
            }
            else if (format == "%")
            {
                result = string.Format("{0:p0}", number);
            }
            else if (format == "r")
            {
                result = string.Format("{0,8}", number);
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
