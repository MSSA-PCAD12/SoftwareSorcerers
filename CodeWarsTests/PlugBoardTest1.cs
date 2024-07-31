using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CodeWars;

namespace CodeWarsTests
{
    [TestClass]
    public class PlugboardTests
    {
        [TestMethod]
        public void Constructor_EmptyString_ShouldInitializeEmptyWiring()
        {
            // Arrange
            var plugboard = new Plugboard("");

            // Act & Assert
            Assert.IsNotNull(plugboard);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_OddLengthString_ShouldThrowArgumentException()
        {
            // Arrange & Act
            var plugboard = new Plugboard("ABC");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_TooManyPairs_ShouldThrowArgumentException()
        {
            // Arrange & Act
            var plugboard = new Plugboard("ABCDEFGHIJKLMNOPQRSTU");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_DuplicatePairs_ShouldThrowArgumentException()
        {
            // Arrange & Act
            var plugboard = new Plugboard("AABB");
        }

        [TestMethod]
        public void Process_InputMappedCharacter_ShouldReturnMappedCharacter()
        {
            // Arrange
            var plugboard = new Plugboard("AB");

            // Act
            var result = plugboard.Process('A');

            // Assert
            Assert.AreEqual('B', result);
        }

        [TestMethod]
        public void Process_InputUnmappedCharacter_ShouldReturnSameCharacter()
        {
            // Arrange
            var plugboard = new Plugboard("AB");

            // Act
            var result = plugboard.Process('C');

            // Assert
            Assert.AreEqual('C', result);
        }
    }
}
