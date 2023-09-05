using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    [TestFixture]
    public class Solution
    {
            [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
            public void LengthTest()
            {
                Assert.AreEqual(false, Kata.ValidatePin("1"), "Wrong output for \"1\"");
                Assert.AreEqual(false, Kata.ValidatePin("12"), "Wrong output for \"12\"");
                Assert.AreEqual(false, Kata.ValidatePin("123"), "Wrong output for \"123\"");
                Assert.AreEqual(false, Kata.ValidatePin("12345"), "Wrong output for \"12345\"");
                Assert.AreEqual(false, Kata.ValidatePin("1234567"), "Wrong output for \"1234567\"");
                Assert.AreEqual(false, Kata.ValidatePin("-1234"), "Wrong output for \"-1234\"");
                Assert.AreEqual(false, Kata.ValidatePin("1.234"), "Wrong output for \"1.234\"");
                Assert.AreEqual(false, Kata.ValidatePin("-1.234"), "Wrong output for \"-1.234\"");
                Assert.AreEqual(false, Kata.ValidatePin("00000000"), "Wrong output for \"00000000\"");
            }

            [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
            public void NonDigitTest()
            {
                Assert.AreEqual(false, Kata.ValidatePin("a234"), "Wrong output for \"a234\"");
                Assert.AreEqual(false, Kata.ValidatePin(".234"), "Wrong output for \".234\"");
            }

            [Test, Description("ValidatePin should return true for valid pins")]
            public void ValidTest()
            {
                Assert.AreEqual(true, Kata.ValidatePin("1234"), "Wrong output for \"1234\"");
                Assert.AreEqual(true, Kata.ValidatePin("0000"), "Wrong output for \"0000\"");
                Assert.AreEqual(true, Kata.ValidatePin("1111"), "Wrong output for \"1111\"");
                Assert.AreEqual(true, Kata.ValidatePin("123456"), "Wrong output for \"123456\"");
                Assert.AreEqual(true, Kata.ValidatePin("098765"), "Wrong output for \"098765\"");
                Assert.AreEqual(true, Kata.ValidatePin("000000"), "Wrong output for \"000000\"");
                Assert.AreEqual(true, Kata.ValidatePin("090909"), "Wrong output for \"090909\"");
        }
        [TestFixture]
        public class SolutionTest
        {
            [Test]
            public void SmallPyramidTest()
            {
                var smallPyramid = new[]
                {
              new[] {3},
              new[] {7, 4},
              new[] {2, 4, 6},
              new[] {8, 5, 9, 3}
          };

                Assert.AreEqual(23, PyramidSlideDown.LongestSlideDown(smallPyramid));
            }

            [Test]
            public void MediumPyramidTest()
            {
                var mediumPyramid = new[]
                {
              new [] {75},
              new [] {95, 64},
              new [] {17, 47, 82},
              new [] {18, 35, 87, 10},
              new [] {20,  4, 82, 47, 65},
              new [] {19,  1, 23, 75,  3, 34},
              new [] {88,  2, 77, 73,  7, 63, 67},
              new [] {99, 65,  4, 28,  6, 16, 70, 92},
              new [] {41, 41, 26, 56, 83, 40, 80, 70, 33},
              new [] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
              new [] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
              new [] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
              new [] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
              new [] {63, 66,  4, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
              new [] { 4, 62, 98, 27, 23,  9, 70, 98, 73, 93, 38, 53, 60,  4, 23}
          };

                Assert.AreEqual(1074, PyramidSlideDown.LongestSlideDown(mediumPyramid));
            }
        }
    }
}
