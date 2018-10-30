using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETConfTDD.Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void ArabicToRoman_From_I_To_III()
        {
            //Arrange
            string expected1 = "I";
            string expected2 = "II";
            string expected3 = "III";

            //Act
            string actual1 = RomanNumerals.ArabicToRoman(1);
            string actual2 = RomanNumerals.ArabicToRoman(2);
            string actual3 = RomanNumerals.ArabicToRoman(3);

            //Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_IV_WhenCalledWith_4()
        {
            string expected = "IV";

            string actual = RomanNumerals.ArabicToRoman(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArabicToRoman_From_V_To_VIII()
        {
            string expected1 = "V";
            string expected2 = "VI";
            string expected3 = "VII";
            string expected4 = "VIII";

            string actual1 = RomanNumerals.ArabicToRoman(5);
            string actual2 = RomanNumerals.ArabicToRoman(6);
            string actual3 = RomanNumerals.ArabicToRoman(7);
            string actual4 = RomanNumerals.ArabicToRoman(8);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_IX_WhenCalledWith_9()
        {
            string expected = "IX";

            string actual = RomanNumerals.ArabicToRoman(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArabicToRoman_From_X_To_XIII()
        {
            string expected1 = "X";
            string expected2 = "XI";
            string expected3 = "XII";
            string expected4 = "XIII";

            string actual1 = RomanNumerals.ArabicToRoman(10);
            string actual2 = RomanNumerals.ArabicToRoman(11);
            string actual3 = RomanNumerals.ArabicToRoman(12);
            string actual4 = RomanNumerals.ArabicToRoman(13);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_XIV_WhenCalledWith_14()
        {
            string expected = "XIV";

            string actual = RomanNumerals.ArabicToRoman(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ArabicToRoman_From_XV_To_XVIII()
        {
            string expected1 = "XV";
            string expected2 = "XVI";
            string expected3 = "XVII";
            string expected4 = "XVIII";

            string actual1 = RomanNumerals.ArabicToRoman(15);
            string actual2 = RomanNumerals.ArabicToRoman(16);
            string actual3 = RomanNumerals.ArabicToRoman(17);
            string actual4 = RomanNumerals.ArabicToRoman(18);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_XX_WhenCalledWith_20()
        {
            string expected = "XX";

            string actual = RomanNumerals.ArabicToRoman(20);

            Assert.AreEqual(expected, actual);
        }
    }
}
