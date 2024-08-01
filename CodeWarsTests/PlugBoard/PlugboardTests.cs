using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars.PlugBoard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.PlugBoard.Tests
{
    [TestClass()]
    public class PlugboardTests
    {
        [TestMethod()]
        public void ProcessTest()
        {
            var pb = new PlugBoard("ABCD");
            Assert.AreEqual('B', pb.Process('A'), "A has to be translated to B with 'AB'");
            Assert.AreEqual('A', pb.Process('B'), "B has to be translated to A with 'AB'");
            Assert.AreEqual('C', pb.Process('D'), "C has to stay C with 'AB'");
            
        }
    }
}