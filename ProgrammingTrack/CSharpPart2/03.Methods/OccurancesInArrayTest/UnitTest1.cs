using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.NumberInArrayCount;

namespace OccurancesInArrayTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForNumberTwo()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 4, 5, 5, 2 };
            int number = 2;

            int result = NumberInArrayCount.OccurancesInArray(array, number);

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void TestForNumberThree()
        {
            int[] array = { 1, 2, 2, 3, 3, 4, 4, 5, 5, 2 };
            int number = 3;

            int result = NumberInArrayCount.OccurancesInArray(array, number);

            Assert.AreEqual(result, 2);
        }
    }
}
