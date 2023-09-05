using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System;

namespace KataTests
{

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(true, Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return true");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "w" }), "should return false");
            Assert.AreEqual(false, Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), "should return false");
        }
        [Test, Description("It should return correct text")]
        public void SampleTestFacebookLikes()
        {
            Assert.AreEqual("no one likes this", Kata.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Kata.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Kata.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Kata.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Kata.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }
    public class Sample_Tests
    {
        [Test]
        public void SampleTest()
        {
            Func<char> abc = Kata.MakeLooper("abc");
            // Two iterations of looper
            // 1
            Assert.AreEqual('a', abc());
            Assert.AreEqual('b', abc());
            Assert.AreEqual('c', abc());
            // 2
            Assert.AreEqual('a', abc());
            Assert.AreEqual('b', abc());
            Assert.AreEqual('c', abc());
        }
    }
    public class GetMiddleTest
    {
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual("es", Kata.GetMiddle("test"));
            Assert.AreEqual("t", Kata.GetMiddle("testing"));
            Assert.AreEqual("dd", Kata.GetMiddle("middle"));
            Assert.AreEqual("A", Kata.GetMiddle("A"));
        }
    }
}
