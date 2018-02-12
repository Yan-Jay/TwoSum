using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {       
        [TestMethod]
        public void TwoSumSuccess()
        {
            var test = new TwoSumClass();
            int[] input = { 2, 7, 11, 15 };
            var target = 9;
            int[] expect = {0,1};
            int[] actual = test.Convert(input, target);
            Assert.AreEqual(expect[0], actual[0]);
            Assert.AreEqual(expect[1], actual[1]);
            
        }
        [TestMethod]
        public void TwoSumError()
        {
            var test = new TwoSumClass();
            int[] input = { 2, 8, 11, 15 };
            var target = 9;
            int[] expect = { 404, 404 };
            int[] actual = test.Convert(input, target);
            Assert.AreEqual(expect[0], actual[0]);
            Assert.AreEqual(expect[1], actual[1]);
        }
        [TestMethod]
        public void TwoSumArrayLongSuccess()
        {
            var test = new TwoSumClass();
            int[] input = { 2, 8, 11, 15,7 };
            var target = 9;
            int[] expect = { 0, 4 };
            int[] actual = test.Convert(input, target);
            Assert.AreEqual(expect[0], actual[0]);
            Assert.AreEqual(expect[1], actual[1]);
        }
    }
}
