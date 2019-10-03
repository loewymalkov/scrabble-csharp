using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Scrabble;

namespace Scrabble.Tests
{
    [TestClass]
    public class ScrabbleTests
    {
        [TestMethod]
        public void Calculations_IndexEachCharacters_TotalScore()
        {
            string input = "EA";
            int result = 2;
            Assert.AreEqual(result, Calculations.StringToCharArray(input));
        }

        [TestMethod]
          public void Calculations_IndexEachMultiPointsCharacters_TotalScore()
        {
            string input = "XZ";
            int result = 18;
            Assert.AreEqual(result, Calculations.StringToCharArray(input));
        }

    }
}