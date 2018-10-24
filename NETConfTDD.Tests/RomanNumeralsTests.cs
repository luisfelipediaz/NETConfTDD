using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETConfTDD.Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void Should_ArabicToRoman_When_1_Return_I()
        {
            //Arrange
            string esperado = "I";

            //Act
            string actual = RomanNumerals.ArabicToRoman(1);

            //Assert
            Assert.AreEqual(esperado, actual);
        }
    }
}
