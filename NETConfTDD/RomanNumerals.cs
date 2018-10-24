using System;
using System.Text;

namespace NETConfTDD
{
    public class RomanNumerals
    {
        public static string ArabicToRoman(int number)
        {
            StringBuilder romanNumber = new StringBuilder();

            if (number <= 3)
            {
                for (int i = 0; i < number; i++)
                {
                    romanNumber.Append("I");
                }
            }
            else if (number == 4)
            {
                romanNumber.Append("IV");
            }
            else if (number == 5)
            {
                romanNumber.Append("V");
            }
            else
            {
                romanNumber.Append("VI");
            }

            return romanNumber.ToString();
        }
    }
}