using CodeWars;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using CodeWars.Domain;

namespace CodeWars.Tests
{
    [TestFixture]
    public static class SolutionsTests
    {
        [Test]
        public static void CanCallIsMerge()
        {
            var s = "TestValue525940261";
            var part1 = "TestValue163659204";
            var part2 = "TestValue775830779";
            var result = Solutions.IsMerge(s, part1, part2);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallIsMergeWithInvalidS(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.IsMerge(value, "TestValue880415504", "TestValue1637201587"));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallIsMergeWithInvalidPart1(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.IsMerge("TestValue100591874", value, "TestValue152117345"));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallIsMergeWithInvalidPart2(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.IsMerge("TestValue235892529", "TestValue1776536034", value));
        }

        [Test]
        public static void CanCallDoneOrNot()
        {
            var board = default(int[][]);
            var result = Solutions.DoneOrNot(board);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallDoneOrNotWithNullBoard()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.DoneOrNot(default(int[][])));
        }

        [Test]
        public static void CanCallsumStrings()
        {
            var a = "TestValue1694201718";
            var b = "TestValue780658496";
            var result = Solutions.sumStrings(a, b);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallsumStringsWithInvalidA(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.sumStrings(value, "TestValue1420361884"));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallsumStringsWithInvalidB(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.sumStrings("TestValue1274922510", value));
        }

        [Test]
        public static void CanCallGetReadableTime()
        {
            var seconds = 668470533;
            var result = Solutions.GetReadableTime(seconds);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CanCallFoldArray()
        {
            var array = default(int[]);
            var runs = 249001331;
            var result = Solutions.FoldArray(array, runs);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallFoldArrayWithNullArray()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.FoldArray(default(int[]), 281581150));
        }

        [Test]
        public static void CanCallSongDecoder()
        {
            var input = "TestValue313024388";
            var result = Solutions.SongDecoder(input);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallSongDecoderWithInvalidInput(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.SongDecoder(value));
        }

        [Test]
        public static void CanCallDirReduc()
        {
            var arr = default(Direction[]);
            var result = Solutions.DirReduc(arr);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallDirReducWithNullArr()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.DirReduc(default(Direction[])));
        }

        [Test]
        public static void CanCallRot13()
        {
            var message = "TestValue772495109";
            var result = Solutions.Rot13(message);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallRot13WithInvalidMessage(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.Rot13(value));
        }

        [Test]
        public static void CanCallDeleteNthWithLINQ()
        {
            var arr = default(int[]);
            var x = 138440487;
            var result = Solutions.DeleteNthWithLINQ(arr, x);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallDeleteNthWithLINQWithNullArr()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.DeleteNthWithLINQ(default(int[]), 1447258255));
        }

        [Test]
        public static void CanCallDeleteNth()
        {
            var arr = default(int[]);
            var x = 1861655660;
            var result = Solutions.DeleteNth(arr, x);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallDeleteNthWithNullArr()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.DeleteNth(default(int[]), 375071677));
        }

        [Test]
        public static void CanCallTitleCase()
        {
            var title = "TestValue1320754356";
            var minorWords = "TestValue953020729";
            var result = Solutions.TitleCase(title, minorWords);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallTitleCaseWithInvalidTitle(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.TitleCase(value, "TestValue396372365"));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallTitleCaseWithInvalidMinorWords(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.TitleCase("TestValue494250702", value));
        }

        [Test]
        public static void CanCallSum()
        {
            var integers = default(int[]);
            var result = Solutions.Sum(integers);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallSumWithNullIntegers()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.Sum(default(int[])));
        }

        [Test]
        public static void CanCallCountChar()
        {
            var chars = default(char[]);
            var charToCount = new char();
            var result = Solutions.CountChar(chars, charToCount);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallCountCharWithNullChars()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.CountChar(default(char[]), new char()));
        }

        [Test]
        public static void CanCallCalculateSquares()
        {
            var start = 729005034;
            var end = 911807542;
            var result = Solutions.CalculateSquares(start, end);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CanCallArrayFind()
        {
            Solutions.ArrayFind();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CanCallGetMissingCandies()
        {
            var candies = default(int[]);
            Solutions.GetMissingCandies(candies);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallGetMissingCandiesWithNullCandies()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.GetMissingCandies(default(int[])));
        }

        [Test]
        public static void CanCallBinaryAddition()
        {
            var a = 1993289172;
            var b = 359159343;
            Solutions.BinaryAddition(a, b);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CanCallLowestAddition()
        {
            var numbers = default(int[]);
            Solutions.LowestAddition(numbers);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallLowestAdditionWithNullNumbers()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.LowestAddition(default(int[])));
        }

        [Test]
        public static void CanCallDisemvowelTrolls()
        {
            var str = "TestValue449254337";
            Solutions.DisemvowelTrolls(str);
            Assert.Fail("Create or modify test");
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallDisemvowelTrollsWithInvalidStr(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.DisemvowelTrolls(value));
        }

        [Test]
        public static void CanCallSorted()
        {
            var array = default(int[]);
            var result = Solutions.Sorted(array);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallSortedWithNullArray()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.Sorted(default(int[])));
        }

        [Test]
        public static void CanCallGetTotal()
        {
            var numbers = new List<int>();
            var result = Solutions.GetTotal(numbers);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallGetTotalWithNullNumbers()
        {
            Assert.Throws<ArgumentNullException>(() => Solutions.GetTotal(default(List<int>)));
        }
    }
}