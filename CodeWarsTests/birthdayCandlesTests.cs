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
    public class birthdayCandlesTests
    {
        [TestMethod()]
        public void BlowCandlesTest1()
        {
            int result = birthdayCandles.BlowCandles("1321");
            Assert.AreEqual(3,result);
        }
        [TestMethod()]
        public void BlowCandlesTest2()
        {
            int result = birthdayCandles.BlowCandles("0323456");
            Assert.AreEqual(9, result);
        }
        [TestMethod()]
        public void BlowCandlesTest3()
        {
            int result = birthdayCandles.BlowCandles("2113");
            Assert.AreEqual(5, result);
        }
        [TestMethod()]
        public void BlowCandlesTest4()
        {
            int result = birthdayCandles.BlowCandles("01110");
            Assert.AreEqual(1, result);
        }
    }
}