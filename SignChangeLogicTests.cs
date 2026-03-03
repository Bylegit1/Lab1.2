using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2.Tests
{
    [TestClass()]
    public class SignChangeLogicTests
    {
        [TestMethod()]
        public void CountSignChangeTest3()
        {
            int[] numbers = { 10, -4, 12, 56, -4 };
            int result = SignChangeLogic.CountSignChange(numbers);
            Assert.AreEqual(3, result);
        }

        [TestMethod()]
        public void CountSignChangeTestPositive()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int result = SignChangeLogic.CountSignChange(numbers);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CountSignChangeTestNegative()
        {
            int[] numbers = { -1, -2, -3, -4, -5 };
            int result = SignChangeLogic.CountSignChange(numbers);
            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CountSignChangeTest4()
        {
            int[] numbers = { 1, -1, 1, -1, 1 };
            int result = SignChangeLogic.CountSignChange(numbers);
            Assert.AreEqual(4, result);
        }
    }
}