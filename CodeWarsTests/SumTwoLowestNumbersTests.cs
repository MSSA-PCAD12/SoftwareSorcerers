using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Tests
{
    [TestClass()]
    public class SumTwoLowestNumbersTests
    {
        [TestMethod()]
        public void sumTwoLowestNumbersTest()
        {
            //Arrange
            int[] input = { 12, 5, 7, 9, 11 };
            //Act
            int result =SumTwoLowestNumbersKata.SumTwoNumbers(input);
            //Assert
            Assert.AreEqual(12, result);

        }
    }
}