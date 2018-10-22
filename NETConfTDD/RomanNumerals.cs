using System;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            string romanNumer = "";
            for (int i = 0; i < number; i++)
            {
                romanNumer += "I";
            }

            return romanNumer;
        }
    }
}