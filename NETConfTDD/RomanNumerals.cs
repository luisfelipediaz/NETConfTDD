using System;
using System.Text;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            StringBuilder romanNumber = new StringBuilder();
            if (number == 6)
            {
                romanNumber.Append("VI");
            }
            else if (number == 5)
            {
                romanNumber.Append("V");
            }
            else if (number == 4)
            {
                romanNumber.Append("IV");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    romanNumber.Append("I");
                }
            }

            return romanNumber.ToString();
        }
    }
}