using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETConfTDD.Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void Should_ArabicToRoman_Return_I()
        {
            //Arrange
            string esperado = "I";

            //Act
            string actual = RomanNumerals.ArabicToRoman(1);

            //Assert
            Assert.AreEqual(esperado, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_II()
        {
            string expected = "II";

            string actual = RomanNumerals.ArabicToRoman(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_ArabicToRoman_Return_III()
        {
            string expected = "III";

            string actual = RomanNumerals.ArabicToRoman(3);

            Assert.AreEqual(expected, actual);
        }
    }
}
