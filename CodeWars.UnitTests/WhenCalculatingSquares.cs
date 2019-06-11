using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars.UnitTests
{
    [TestClass]
    public class WhenCalculatingSquares
    {

        [TestMethod]
        public void ThenSameValuesAreInvalid()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Solutions.CalculateSquares(5, 5));
        }

        [TestMethod]
        public void ThenANegativeDifferenceIsInvalid()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => Solutions.CalculateSquares(5, 4));
        }

        [TestMethod]
        public void ThenValidInputsWillCalculateCorrectSquares()
        {
            int[] ans = Solutions.CalculateSquares(1, 4);

            Assert.AreEqual(1, ans[0]);
            Assert.AreEqual(4, ans[1]);
            Assert.AreEqual(9, ans[2]);
        }
    }
}
