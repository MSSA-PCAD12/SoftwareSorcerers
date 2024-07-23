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
    public class LostNumTests
    {
        [TestMethod()]
        public void LostNumberTest()
        {
            // Arrange
            var starting = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var mixedList = new List<int>() { 3, 2, 4, 6, 7, 8, 1, 9 };
           
            // Act
            var result = starting.Sum() - mixedList.Sum();

            // Assert
            Assert.AreEqual(5, result);

        }
    }
}