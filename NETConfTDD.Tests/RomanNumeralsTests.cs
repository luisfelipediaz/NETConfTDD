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
            string esperado = "I";

            string actual = RomanNumerals.ArabicToRoman(1);

            Assert.AreEqual(esperado, actual);
        }
    }
}
