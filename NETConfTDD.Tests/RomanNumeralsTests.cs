using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NETConfTDD.Tests
{
    [TestClass]
    public class RomanNumeralsTests
    {
        [TestMethod]
        public void WhenInputIs1ThenShouldReturnI()
        {
            //Arrange - Setup
            string expected = "I";
            //Act - Exec
            string actual = RomanNumerals.ArabicToRoman(1);
            //Assert
            Assert.AreEqual(expected, actual);
        }      
    }
}
