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
            else if (number >= 5 && number <= 8)
            {
                romanNumber.Append("V");
                for (int i = 5; i < number; i++)
                {
                    romanNumber.Append("I");
                }
            }
            else if (number == 9)
            {
                romanNumber.Append("IX");
            }
            else if (number == 10)
            {
                romanNumber.Append("X");
            }
            else if (number == 11)
            {
                romanNumber.Append("XI");
            }
            else if (number == 12)
            {
                romanNumber.Append("XII");
            }
            else
            {
                romanNumber.Append("XIII");
            }

            return romanNumber.ToString();
        }
    }
}