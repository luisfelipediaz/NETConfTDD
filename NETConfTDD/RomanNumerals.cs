using System;
using System.Text;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            StringBuilder romanNumber = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                romanNumber.Append("I");
            }

            return romanNumber.ToString();
        }
    }
}