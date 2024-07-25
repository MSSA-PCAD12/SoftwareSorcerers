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

    public class SpinWordsTests
        {
            [TestMethod()]
            public static void SpinWordsMainTest1()

            {
                Assert.AreEqual("emocleW", SpinWords.SpinWordsMain("Welcome"));
            }

            [TestMethod()]
            public static void Test2()

            {
                Assert.AreEqual("Hey wollef sroirraw", SpinWords.SpinWordsMain("Hey fellow warriors"));
            }

            [TestMethod()]
            public static void Test3()

            {
                Assert.AreEqual("This is a test", SpinWords.SpinWordsMain("This is a test"));
            }

            [TestMethod()]
            public static void Test4()

            {
                Assert.AreEqual("This is rehtona test", SpinWords.SpinWordsMain("This is another test"));
            }

            [TestMethod()]
            public static void Test5()

            {
                Assert.AreEqual("You are tsomla to the last test", SpinWords.SpinWordsMain("You are almost to the last test"));
            }

            [TestMethod()]
            public static void Test6()

            {
                Assert.AreEqual("Just gniddik ereht is llits one more", SpinWords.SpinWordsMain("Just kidding there is still one more"));
            }

        }

    }