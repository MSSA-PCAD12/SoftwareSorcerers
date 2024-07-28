using RPN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPN.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void EvaluationTest()
        {
            //Arrange
            string rpnExpression = " ";
            double expectedResult = 0;
            //Act
            double actualResult = RPNCalc.Evaluation(rpnExpression);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod()]
        public void EvaluationTest2()
        {
            string rpnExpression = "3";
            double expectedResult = 3;
            double actualResult = RPNCalc.Evaluation(rpnExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void EvaluationTest3()
        {
            string rpnExpression = "1 3 +";
            double expectedResult = 4;
            double actualResult = RPNCalc.Evaluation(rpnExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void EvaluationTest4()
        {
            string rpnExpression = "1 3 *";
            double expectedResult = 3;
            double actualResult = RPNCalc.Evaluation(rpnExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void EvaluationTest5()
        {
            string rpnExpression = "1 3 -";
            double expectedResult = -2;
            double actualResult = RPNCalc.Evaluation(rpnExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod()]
        public void EvaluationTest6()
        {
            string rpnExpression = "4 2 /";
            double expectedResult = 2;
            double actualResult = RPNCalc.Evaluation(rpnExpression);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
