using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeWars.UnitTests
{
    [TestClass]
    public class WhenFormattingATittle
    {
        [TestMethod]
        public void ThenAllLowerCaseWorks()
        {
            Assert.AreEqual("A Clash of Kings", Solutions.TitleCase("a clash of kings", "a an the of"));
        }

        [TestMethod]
        public void ThenAllUpperCaseWorks()
        {
            Assert.AreEqual("A Clash of Kings", Solutions.TitleCase("A CLASH OF KINGS", "a an the of"));
        }

        [TestMethod]
        public void ThenMixedCaseWorks()
        {
            Assert.AreEqual("A Clash of Kings", Solutions.TitleCase("A cLaSh Of KiNgS", "a an the of"));
        }

        [TestMethod]
        public void ThenNullMinorWordsAreHandled()
        {
            Assert.AreEqual("A Clash Of Kings", Solutions.TitleCase("A CLASH OF KINGS", null));
        }

        [TestMethod]
        public void ThenEmptyMinorWordsAreHandled()
        {
            Assert.AreEqual("A Clash Of Kings", Solutions.TitleCase("A CLASH OF KINGS", ""));
        }

        [TestMethod]
        public void ThenReversedStringWorks()
        {
            char[] arr = (Solutions.TitleCase("A cLaSh Of KiNgS", "a an the of").ToCharArray());

            Array.Reverse(arr);
            string reverse = new string(arr);

            Assert.AreEqual("Sgnik Fo Hsalc a", Solutions.TitleCase(reverse, "a"));
        }
    }
}
