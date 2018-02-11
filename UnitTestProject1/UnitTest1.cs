using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {       
        [TestMethod]
        public void TestMethod1()
        {
            var test = new TwoSumClass();
            int[] input = { 2, 7, 11, 15 };
            var target = 9;
            int[] expect = {0,1 };
            int[] actual = test.Convert(input, target);
            Assert.AreEqual(expect, actual);
        }
    }
}
