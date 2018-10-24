using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETConfTDD.Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void Should_ArabicToRoman_Return_I_WhenCalledWith_1()
        {
            //Arrange
            string esperado = "I";

            //Act
            string actual = RomanNumerals.ArabicToRoman(1);

            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_II_WhenCalledWith_2()
        {
            string expected = "II";

            string actual = RomanNumerals.ArabicToRoman(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_III_WhenCalledWith_3()
        {
            string expected = "III";

            string actual = RomanNumerals.ArabicToRoman(3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_IV_WhenCalledWith_4()
        {
            string expected = "IV";

            string actual = RomanNumerals.ArabicToRoman(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_V_WhenCalledWith_5()
        {
            string expected = "V";

            string actual = RomanNumerals.ArabicToRoman(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_VI_WhenCalledWith_6()
        {
            string expected = "VI";

            string actual = RomanNumerals.ArabicToRoman(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_VII_WhenCalledWith_7()
        {
            string expected = "VII";

            string actual = RomanNumerals.ArabicToRoman(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_VII_WhenCalledWith_8()
        {
            string expected = "VIII";

            string actual = RomanNumerals.ArabicToRoman(7);

            Assert.AreEqual(expected, actual);
        }
    }
}
