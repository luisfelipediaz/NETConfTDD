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
            else if (number == 6)
            {
                romanNumber.Append("VI");
            }
            else if (number == 7)
            {
                romanNumber.Append("VII");
            }
            else
            {
                romanNumber.Append("VIII");
            }

            return romanNumber.ToString();
        }
    }
}