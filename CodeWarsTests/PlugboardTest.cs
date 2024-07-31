using System;
using CodeWars;

namespace CodeWarsTests
{
    [TestClass]
    public class PlugboardTests
    {
        [TestMethod]
        public void Test_ValidWiringPairs()
        {
            var plugboard = new Plugboard("ABCD");
            Assert.AreEqual('B', plugboard.Process('A')); 
            Assert.AreEqual('A', plugboard.Process('B')); 
            Assert.AreEqual('D', plugboard.Process('C')); 
            Assert.AreEqual('C', plugboard.Process('D')); 
            Assert.AreEqual('X', plugboard.Process('X')); 
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_InvalidWiringPairs_ThrowsException()
        {

            var plugboard = new Plugboard("ABC");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_InvalidCharacterInWiringPairs_ThrowsException()
        {

            var plugboard = new Plugboard("AB1C");
        }

        [TestMethod]
        public void Test_ProcessingNonAlphabetCharacter()
        {
            var plugboard = new Plugboard("ABCD");
            Assert.AreEqual('.', plugboard.Process('.')); 
        }
    }
}
