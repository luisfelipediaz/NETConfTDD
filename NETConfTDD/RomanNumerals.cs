using System;
using System.Text;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            StringBuilder romanNumber = new StringBuilder();
            if (number >= 5)
            {
                romanNumber.Append("V");
                number -= 5;
            }

            if (number == 4)
            {
                romanNumber.Append("IV");
                number -= 4;
            }

            for (int i = 0; i < number; i++)
            {
                romanNumber.Append("I");
            }

            return romanNumber.ToString();
        }
    }
}