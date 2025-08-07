using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyConsoleApp;

namespace MyConsoleApp.Tests
{
    [TestClass]
    public class Activity1Tests
    {
        [TestMethod]
        public void GetVariableDataTypes_ReturnsCorrectString()
        {
            // Arrange
            var activity1 = new Activity1();
            var expected = "Age: 20, Name: Anna, Is Student: True";

            // Act
            var result = activity1.GetVariableDataTypes();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}