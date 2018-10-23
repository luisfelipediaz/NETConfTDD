using System;
using System.Text;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            StringBuilder romanNumber = new StringBuilder();
            int remaining = number;
            if (remaining == 9)
            {
                romanNumber.Append("IX");
                remaining -= 9;
            }
            if (remaining >= 5)
            {
                romanNumber.Append("V");
                remaining -= 5;
            }

            if (remaining == 4)
            {
                romanNumber.Append("IV");
                remaining -= 4;
            }

            for (int i = 0; i < remaining; i++)
            {
                romanNumber.Append("I");
            }

            return romanNumber.ToString();
        }
    }
}