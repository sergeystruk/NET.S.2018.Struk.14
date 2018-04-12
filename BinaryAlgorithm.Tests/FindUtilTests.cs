using System;
using NUnit.Framework;

namespace BinaryAlgorithm.Tests
{
    [TestFixture]
    public class FindUtilTests
    {
        [Test]
        public void BinarySearch_TestStrings()
        {
            string[] array = {"abc", "abcabc", "bcd", "aaa", "dcc", "abc"};
            Array.Sort(array);

            Assert.AreEqual(Array.BinarySearch(array, "abc"), FindUtil.BinarySearch(array, "abc"));
        }

        [Test]
        public void BinarySearch_TestDoubles()
        {
            double[] array = {13.22, -5.88, double.MaxValue, double.MinValue, 0, 0.14, 0.000001};
            Array.Sort(array);

            Assert.AreEqual(Array.BinarySearch(array, 0.000001), FindUtil.BinarySearch(array, 0.000001));
        }

        [Test]
        public void BinarySearch_TestNotExist()
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            Array.Sort(array);

            Assert.AreEqual(FindUtil.BinarySearch(array, 10), -1);
        }

        [Test]
        public void BinarySearch_TestWithNull()
        {
            Assert.Throws<ArgumentNullException>(() => FindUtil.BinarySearch(null, 4));
        }
    }
}
