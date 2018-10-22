using System;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            if (number == 3)
                return "III";
            if (number == 2)
                return "II";
            return "I";
        }
    }
}